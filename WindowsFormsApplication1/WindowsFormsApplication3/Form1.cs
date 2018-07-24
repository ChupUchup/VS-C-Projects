using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        #region variables

        const uint
            w_down = 0x00000047,
            w_ch = 0x00000067,
            w_up = 0x00000047,
            l_down = 0x00220001,
            l_ch = 0x00220001,
            l_up = 0xC0220001,

            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101,
            WM_CHAR = 0x0102,
            WM_MOUSEMOVE = 0x200,
            WM_LBUTTONDOWN = 0x201,
            WM_LBUTTONUP = 0x202,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,
            WM_SETCURSOR = 0x0020,
            WM_MOUSEACTIVATE = 0x0021;

        IKeyboardMouseEvents _hook;
        bool run = false, stop = false, hooked = false;
        int[] _list_pid = new int[0];
        int repeat = 0;
        IntPtr[] _list_hwnd = new IntPtr[0];
        string[] _list_pos = new string[0];

        #endregion variables

        #region native method

        [DllImport("User32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern void GetWindowRect(IntPtr hWmnd, ref Rectangle rect);

        [DllImport("user32.dll")]
        public static extern void GetClientRect(IntPtr hWmnd, ref Rectangle rect);

        #endregion native method

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            start_hook();
            reset();
        }

        private void txt_repeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            string message = "Tekan F11 untuk menyimpan posisi \nTekan F12 untuk memulai atau berhenti \n0 Kali = Unlimited";
            MessageBox.Show(message, "Help !", MessageBoxButtons.OK);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void list_process_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            _list_hwnd = get_hwnd();
        }

        private void btn_hook_Click(object sender, EventArgs e)
        {
            if (hooked)
                stop_hook();
            else
                start_hook();
        }

        private void _hook_MouseMove(object sender, MouseEventArgs e)
        {
            txt_x.Text = e.X.ToString();
            txt_y.Text = (e.Y - 18).ToString();
        }

        private void _hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                list_pos.Items.Add(new ListViewItem(new string[] { txt_x.Text, txt_y.Text }));
            }
            else if (e.KeyCode == Keys.F12)
            {
                run_process();
            }
        }

        private void start_hook()
        {
            _hook = Hook.GlobalEvents();
            _hook.MouseMove += _hook_MouseMove;
            _hook.KeyDown += _hook_KeyDown;
            btn_hook.BackColor = Color.Red;
            btn_hook.Text = "Stop Hook";
            hooked = true;
        }

        private void stop_hook()
        {
            _hook.Dispose();
            btn_hook.BackColor = Color.Lime;
            btn_hook.Text = "Start Hook";
            hooked = false;
        }

        private void reset()
        {
            list_pos.Items.Clear();
            list_process.Items.Clear();
            _list_pid = get_pid();
            foreach (int i in _list_pid)
                list_process.Items.Add(new ListViewItem(new string[] { "Atlantica.exe", i.ToString() }));
            foreach (ListViewItem i in list_process.Items)
                i.Checked = true;
        }

        private int[] get_pid()
        {
            var list_process = Process.GetProcessesByName("Atlantica");
            var list_pid = new int[list_process.Count()];
            for (int i = 0; i < list_process.Count(); i++)
            {
                list_pid[i] = list_process[i].Id;
            }
            return list_pid;
        }

        private IntPtr[] get_hwnd()
        {
            var list_hwnd = new IntPtr[0];
            foreach (ListViewItem i in list_process.Items)
            {
                if (i.Checked)
                {
                    Array.Resize(ref list_hwnd, list_hwnd.Length + 1);
                    var a = Process.GetProcessById(Convert.ToInt32(i.SubItems[1].Text)).MainWindowHandle;
                    list_hwnd[list_hwnd.GetUpperBound(0)] = a;
                }
            }
            return list_hwnd;
        }

        private string[] get_pos()
        {
            string[] _pos = new string[list_pos.Items.Count];
            for (int i = 0; i < _pos.Length; i++)
            {
                _pos[i] =
                    Convert.ToString(
                    Convert.ToInt32(list_pos.Items[i].SubItems[1].Text), 16).PadLeft(4, '0') +
                    Convert.ToString(
                    Convert.ToInt32(list_pos.Items[i].SubItems[0].Text), 16).PadLeft(4, '0');
            }
            return _pos;
        }

        private async void run_process()
        {
            if (!run)
            {
                run = true;
                repeat = Convert.ToInt32(txt_repeat.Text);
                _list_pid = get_pid();
                _list_hwnd = get_hwnd();
                _list_pos = get_pos();
                //list_pos.Items.Add(new ListViewItem(new string[] { Convert.ToString(500, 16).PadLeft(4, '0'), Convert.ToString(500, 16).PadLeft(4, '0') }));
                for (int i = 0; i < repeat; i++)
                {
                    lbl_count.Text = "/" + (i + 1).ToString();
                    if (!stop)
                        await do_click();
                    else
                    {
                        run = false;
                        stop = false;
                        break;
                    }
                }
                run = false;
                stop = false;
            }
            else
            {
                //run = false;
                stop = true;
            }
        }

        private async Task<int> do_click()
        {
            foreach (string _pos in _list_pos)
            {
                foreach (IntPtr _hwnd in _list_hwnd)
                {
                    var _lParam = new IntPtr(Convert.ToInt32(_pos, 16));
                    PostMessage(_hwnd, WM_MOUSEMOVE, IntPtr.Zero, _lParam);
                    SendMessage(_hwnd, WM_MOUSEACTIVATE, new IntPtr(Convert.ToInt32("00100628", 16)), new IntPtr(Convert.ToInt32("02010001", 16)));
                    uint a = 0, b = 0;
                    if (radio_kiri.Checked)
                    {
                        a = WM_LBUTTONDOWN;
                        b = WM_LBUTTONUP;
                    }
                    else if (radio_kanan.Checked)
                    {
                        a = WM_RBUTTONDOWN;
                        b = WM_RBUTTONUP;
                    }
                    PostMessage(_hwnd, a, new IntPtr(1), _lParam);
                    PostMessage(_hwnd, b, IntPtr.Zero, _lParam);
                    //new System.Threading.ManualResetEvent(false).WaitOne(500);
                }
                await Task.Delay(Convert.ToInt32(num_interval.Value * 1000));
            }
            return 0;
        }

    }
}

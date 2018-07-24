using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
//using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        #region variables

        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;
        const int WM_CHAR = 0x0102;

        uint
                w_down = 0x00000047,
                w_ch = 0x00000067,
                w_up = 0x00000047,
                l_down = 0x00220001,
                l_ch = 0x00220001,
                l_up = 0xC0220001;

        Timer t = new Timer();
        IntPtr[] _list_hwnd = new IntPtr[0];
        int[] _list_pid = new int[0];
        long count = 0;

        #endregion variables

        #region native method

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, uint wParam, uint lParam);
        
        #endregion native method

        public Form1()
        {
            InitializeComponent();
            t.Interval = Convert.ToInt32(num_interfal.Value) * 1000;
            t.Enabled = false;
            t.Tick += (e, a) => { dosomething(ref _list_hwnd); };
        }

        private void btn_spam_Click(object sender, EventArgs e)
        {
            if (t.Enabled)
            {
                btn_refresh.Visible = true;
                t.Enabled = false;
                t.Stop();
                btn_spam.Text = "Spam G";
                btn_spam.BackColor = Color.Lime;
                lbl_count.Text = "Count : ";
            }
            else
            {
                _list_hwnd = get_hwnd();
                if (_list_hwnd.Length > 0)
                {
                    count = 0;
                    btn_refresh.Visible = false;
                    t.Enabled = true;
                    t.Start();
                    btn_spam.Text = "Stop G";
                    btn_spam.BackColor = Color.Red;
                }
            }
        }

        private void dosomething(ref IntPtr[] list_hwnd)
        {
            if (list_hwnd.Length > 0)
            {
                foreach (IntPtr hwnd in list_hwnd)
                {
                    SendMessage(hwnd, WM_KEYDOWN, w_down, l_down);
                    SendMessage(hwnd, WM_CHAR, w_ch, l_ch);
                    SendMessage(hwnd, WM_KEYUP, w_up, l_up);
                }
                count += 1;
                lbl_count.Text = "Count : " + count.ToString();
            }
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

        private void refresh_process()
        {
            _list_pid = get_pid();
            list_process.Items.Clear();
            for (int i = 0; i < _list_pid.Count(); i++)
            {
                list_process.Items.Add(new ListViewItem(new string[] { "Atlantica.exe", _list_pid[i].ToString() }));
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            refresh_process();
        }

        private void num_interval_ValueChange(object sender, EventArgs e)
        {
            t.Interval = Convert.ToInt32(num_interfal.Value) * 1000;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh_process();
        }

        private void list_process_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            _list_hwnd = get_hwnd();
        }
    }
}

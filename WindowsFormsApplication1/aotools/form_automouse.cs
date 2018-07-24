using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using Win32API;
using System.Diagnostics;

namespace aotools
{
    public partial class form_automouse : Form
    {
        #region variable

        IKeyboardMouseEvents hook;
        //const int x_border = 3, y_border = 26;
        bool hooked = false, run = false, stop = false;
        int counter = 0;
        //public int[] _list_pid = new int[0];
        string[] _list_pos = new string[0];
        public IntPtr[] _list_hwnd = new IntPtr[0];

        #endregion variable

        public form_automouse()
        {
            InitializeComponent();
        }

        private void form_automouse_Shown(object sender, EventArgs e)
        {
            hook_start();
            btn_hook_Click(null, null);
        }

        private void txt_ulang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btn_hook_Click(object sender, EventArgs e)
        {
            if (!hooked)
            {
                btn_hook.BackColor = Color.Red;
                btn_hook.Text = "U";
                hooked = true;
            }
            else
            {
                reset_txt_pos();
                btn_hook.BackColor = Color.Lime;
                btn_hook.Text = "H";
                hooked = false;
            }
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            form_target_process f = new form_target_process();
            f.Owner = this;
            f.ShowDialog();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            run_process();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            list_pos.Items.Clear();
            radio_left.Checked = true;
            num_delay.Value = 1;
            txt_counter.Text = "1";
            run = false; stop = false;
            _list_pos = new string[0];
            _list_hwnd = new IntPtr[0];
            update_run_status(1);
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            form_messagebox f = new form_messagebox();
            f.ShowDialog();
        }

        private void hook_MouseMove(object sender, MouseEventArgs e)
        {
            if (hooked)
            {
                if (Native.GetHwnds("Atlantica").Contains(Native.GetForegroundWindow()))
                {
                    Rectangle wRect = new Rectangle();
                    Native.GetWindowRect(Native.GetForegroundWindow(), out wRect);
                    //int x = e.X - wRect.X - x_border,
                    //    y = e.Y - wRect.Y - y_border;
                    //if (x > -1 && y > -1 && x < (wRect.Width - wRect.X - (x_border * 2)) && y < (wRect.Height - wRect.Y - y_border - x_border))
                    //{
                    //    txt_c_x.Text = x.ToString();
                    //    txt_c_y.Text = y.ToString();
                    //}
                    int x = e.X - wRect.X,
                        y = e.Y - wRect.Y;
                    if (x > -1 && y > -1 && x < (wRect.Width - wRect.X) && y < (wRect.Height - wRect.Y))
                    {
                        txt_c_x.Text = x.ToString();
                        txt_c_y.Text = (y - 18).ToString();
                    }
                    else
                        reset_txt_pos();
                }
                else
                    reset_txt_pos();
            }
        }

        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (Native.GetHwnds("Atlantica").Contains(Native.GetForegroundWindow()) && !run && hooked)
            {
                if (e.KeyCode == Keys.F11)
                    if (txt_c_x.Text != "0" && txt_c_y.Text != "0")
                        list_pos.Items.Add(new ListViewItem(new string[] { txt_c_x.Text, txt_c_y.Text }));
            }
        }

        void hook_start()
        {
            hook = Hook.GlobalEvents();
            hook.KeyDown += hook_KeyDown;
            hook.MouseMove += hook_MouseMove;
        }

        void hook_stop()
        {
            if (hook != null)
                hook.Dispose();
        }

        void reset_txt_pos()
        {
            txt_c_x.Text = "0";
            txt_c_y.Text = "0";
        }

        void update_run_status(int run_counter)
        {
            if (run)
                this.Text = "Run : " + run_counter.ToString() + "/" + txt_counter.Text;
            else
                this.Text = "automouse";
        }

        void update_control_status()
        {
            if (run)
            {
                btn_hook.Enabled = false;
                btn_target.Enabled = false;
                btn_reset.Enabled = false;
                radio_left.Enabled = false;
                radio_right.Enabled = false;
                num_delay.Enabled = false;
                txt_counter.Enabled = false;
                list_pos.Enabled = false;
                btn_run.Image = Properties.Resources.stop;
            }
            else
            {
                btn_hook.Enabled = true;
                btn_target.Enabled = true;
                btn_reset.Enabled = true;
                radio_left.Enabled = true;
                radio_right.Enabled = true;
                num_delay.Enabled = true;
                txt_counter.Enabled = true;
                list_pos.Enabled = true;
                btn_run.Image = Properties.Resources.start;
            }
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
                _list_pos = get_pos();
                if (_list_pos.Length > 0)
                {
                    if (_list_hwnd.Length > 0)
                    {
                        run = true;
                        update_control_status();
                        counter = Convert.ToInt32(txt_counter.Text);
                        //_list_hwnd = Native.GetHwnds("Atlantica");
                        for (int i = 0; i < counter; i++)
                        {
                            update_run_status(i + 1);
                            if (!stop)
                                await do_click();
                            else
                                break;
                        }
                    }
                    else
                        MessageBox.Show("Pilih target Atlantica terlebih dahulu", "Alert", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Belum ada koordinat tersimpan", "Alert", MessageBoxButtons.OK);
                run = false;
                stop = false;
                update_control_status();
            }
            else
                stop = true;
        }

        private async Task<int> do_click()
        {
            foreach (string _pos in _list_pos)
            {
                foreach (IntPtr _hwnd in _list_hwnd)
                {
                    var _lParam = (uint)Convert.ToInt32(_pos, 16);
                    //Native.SendMessage(_hwnd, Native.WM_MOUSEMOVE, IntPtr.Zero, _lParam);
                    //Native.SendMessage(_hwnd, Native.WM_MOUSEACTIVATE, new IntPtr(Convert.ToInt32("00100628", 16)), new IntPtr(Convert.ToInt32("02010001", 16)));
                    uint a = 0, b = 0;
                    if (radio_left.Checked)
                    {
                        a = Native.WM_LBUTTONDOWN;
                        b = Native.WM_LBUTTONUP;
                    }
                    else if (radio_right.Checked)
                    {
                        a = Native.WM_RBUTTONDOWN;
                        b = Native.WM_RBUTTONUP;
                    }
                    //Native.SendMessage(_hwnd, a, new IntPtr(1), _lParam);
                    //Native.SendMessage(_hwnd, b, IntPtr.Zero, _lParam);
                    //new System.Threading.ManualResetEvent(false).WaitOne(500);

                    //Native.SendMessage(_hwnd, Native.WM_MOUSEMOVE, 0, _lParam);
                    Native.SendMessage(_hwnd, a, 0, _lParam);
                    Native.SendMessage(_hwnd, b, 0, _lParam);
                }
                await Task.Delay(Convert.ToInt32(num_delay.Value * 1000));
            }
            return 0;
        }

    }
}

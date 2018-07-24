using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook;
using WndProcWrapper;

namespace SimulateKeyboard
{
    public partial class form_main : Form
    {
        IKeyboardMouseEvents hook;
        IntPtr wHandle = IntPtr.Zero;
        Timer timer = new Timer();
        int counter = 0;

        public form_main()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 1, 1, 1);
            this.TransparencyKey = Color.FromArgb(255, 1, 1, 1);
            this.AllowTransparency = true;
            timer.Interval = Convert.ToInt32(num_delay.Value * (decimal)1000);
            timer.Enabled = false;
            timer.Tick += (s, e) => { dowork(); };
            hook = Hook.GlobalEvents();
            hook.KeyDown += hook_KeyDown;
        }

        void hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                wHandle = NativeMethod.GetForegroundWindow();
                NativeMethod.ShowWindow(wHandle, (uint)NativeConst.SW_SHOW);
                NativeMethod.SetForegroundWindow(wHandle);
                Rectangle wRect = new Rectangle();
                NativeMethod.GetWindowRect(wHandle, out wRect);
                this.Location = new Point(wRect.X, wRect.Y);
                panel_control.BackColor = Color.FromArgb(192, 255, 192);
            }
            else if (e.KeyCode == Keys.End)
            {
                wHandle = IntPtr.Zero;
                timerstop();
                panel_control.BackColor = Color.FromArgb(255, 192, 192);
            }
            else if (NativeMethod.GetForegroundWindow() == wHandle)
            {
                if (e.KeyCode == Keys.X)
                {
                    if (timer.Enabled)
                        timerstop();
                    else
                        timerstart();
                }
                else if (e.KeyCode == Keys.F11)
                {
                    if (num_delay.Value < num_delay.Maximum)
                        num_delay.Value += (decimal)0.1;
                }
                else if (e.KeyCode == Keys.F12)
                {
                    if (num_delay.Value > num_delay.Minimum)
                        num_delay.Value -= (decimal)0.1;
                }
            }
        }

        private void dowork()
        {
            if (wHandle != IntPtr.Zero)
            {
                
                //NativeMethod.SendMessage(wHandle, 0x100, 0x58, 0x0);//0x002D0001);
                //NativeMethod.SendMessage(wHandle, 0x102, 0x78, 0x002D0001);
                //NativeMethod.SendMessage(wHandle, 0x101, 0x58, 0xC02D0001);
                //NativeMethod.SetFocus(wHandle);
                NativeMethod.SetForegroundWindow(wHandle);
                NativeMethod.SendMessage(wHandle, 0x100, (uint)Keys.X, 0x0);
                NativeMethod.SendMessage(wHandle, 0x100, (uint)Keys.Space, 0x0);
                //NativeMethod.PostThreadMessage(0x364, 0x100, 0x58, 0x0);
                lbl_counter.Text = counter.ToString();
                counter += 1;
            }
            else
                timerstop();
        }

        private void timerstart()
        {
            timer.Enabled = true;
            timer.Start();
            check_pick.Checked = true;
        }

        private void timerstop()
        {
            timer.Enabled = false;
            timer.Stop();
            check_pick.Checked = false;
            counter = 0;
        }

        private void panel_control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethod.ReleaseCapture();
                NativeMethod.SendMessage(this.Handle, (uint)NativeConst.WM_NCLBUTTONDOWN, (uint)NativeConst.HT_CAPTION, 0);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void num_delay_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = Convert.ToInt32(num_delay.Value * (decimal)1000);
        }
    }
}

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

namespace SimulateMouse
{
    public partial class form_main : Form
    {
        IKeyboardMouseEvents hook;
        IntPtr targetHandle = IntPtr.Zero;
        Rectangle clientRect = new Rectangle();
        POINT p = new POINT();
        Color currentColor = new Color();


        public form_main()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 1, 1, 1);
            this.TransparencyKey = Color.FromArgb(255, 1, 1, 1);
            this.AllowTransparency = true;
            currentColor = panel_utama.BackColor;
            panel_record.BackColor = currentColor;
            list_record.BackColor = currentColor;
            panel_record.Visible = false;

            panel_processlist.BackColor = currentColor;
            list_process.BackColor = currentColor;
            panel_processlist.Visible = false;


            hook = Hook.GlobalEvents();
            hook.KeyDown += hook_KeyDown;
            hook.MouseMove += hook_MouseMove;
        }

        void hook_MouseMove(object sender, MouseEventArgs e)
        {
            if (targetHandle == NativeMethod.GetForegroundWindow())
            {
                NativeMethod.GetCursorPos(ref p);
                NativeMethod.ScreenToClient(targetHandle, ref p);
                if (p.x < 0 || p.y < 0 || p.x > clientRect.Width || p.y > clientRect.Height)
                {
                    lbl_x.Text = "X:";
                    lbl_y.Text = "Y:";
                }
                else
                {
                    lbl_x.Text = "X:" + p.x.ToString();
                    lbl_y.Text = "Y:" + p.y.ToString();
                }
            }
        }

        void hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
            {
                targetHandle = NativeMethod.GetForegroundWindow();
                NativeMethod.GetClientRect(targetHandle, out clientRect);
                //this.Text = targetHandle.ToString("X8");
                //test(targetHandle);
            }
            else if (e.KeyCode == Keys.PageDown)
            {
                targetHandle = IntPtr.Zero;
                this.Text = "Simulate Keyboard";
            }
            else if (e.KeyCode == Keys.F12)
            {
                if (targetHandle != IntPtr.Zero)
                {
                    NativeMethod.PostMessage(targetHandle, (uint)NativeConst.WM_MOUSEMOVE, 0, 0x01F401F4);
                    NativeMethod.PostMessage(targetHandle, (uint)NativeConst.WM_LBUTTONDOWN, 0, 0x01F401F4);
                    NativeMethod.PostMessage(targetHandle, (uint)NativeConst.WM_LBUTTONUP, 0, 0x01F401F4);
                }
            }
        }

        private void panel_utama_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethod.ReleaseCapture();
                NativeMethod.SendMessage(this.Handle, (uint)NativeConst.WM_NCLBUTTONDOWN, (uint)NativeConst.HT_CAPTION, 0);
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_saverecord_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(192, 192, 255);
        }

        private void lbl_saverecord_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = currentColor;
        }

        private void lbl_saverecord_Click(object sender, EventArgs e)
        {
            if (panel_record.Visible)
                panel_record.Visible = false;
            else
                panel_record.Visible = true;
        }

        private void lbl_processlist_Click(object sender, EventArgs e)
        {
            if (panel_processlist.Visible)
                panel_processlist.Visible = false;
            else
                panel_processlist.Visible = true;
        }

        private void lbl_reset_Click(object sender, EventArgs e)
        {

        }

        private void lbl_help_Click(object sender, EventArgs e)
        {
            uint vol = 0, max = 0;
            FileSystemFeature f = new FileSystemFeature();
            NativeMethod.GetVolumeInformation("C:", new StringBuilder(), 0, out vol, out max, out f, new StringBuilder(), 0);
            textBox1.Text = vol.ToString();


            uint serialNum, serialNumLength;
            FileSystemFeature flags;
            StringBuilder volumename = new StringBuilder(256);
            StringBuilder fstype = new StringBuilder(256);

            bool ok = NativeMethod.GetVolumeInformation("C:\\", volumename, (uint)volumename.Capacity - 1, out serialNum, out serialNumLength, out flags, fstype, (uint)fstype.Capacity - 1);
            if (ok)
                textBox1.Text = serialNum.ToString("X");
            var x = new System.IO.DriveInfo("C:\\ ");
            textBox2.Text = x.VolumeLabel;
        }

    }
}

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
using Win32API;
using Gma.System.MouseKeyHook;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        Timer t;
        IKeyboardMouseEvents _hook;
        bool hooked = false, resize = false;
        int w = 1030, h = 784;

        public Form1()
        {
            InitializeComponent();
            t = new Timer();
            t.Interval = 250;
            t.Tick += t_Tick;
        }

        private void start_hook()
        {
            _hook = Hook.GlobalEvents();
            _hook.MouseMove += _hook_MouseMove;
            _hook.KeyDown += _hook_KeyDown;
            //btn_hook.BackColor = Color.Red;
            //btn_hook.Text = "Stop Hook";
            hooked = true;
        }

        private void stop_hook()
        {
            if (_hook != null)
                _hook.Dispose();
            //btn_hook.BackColor = Color.Lime;
            //btn_hook.Text = "Start Hook";
            hooked = false;
        }

        void _hook_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        void _hook_MouseMove(object sender, MouseEventArgs e)
        {
            if (hooked)
            {
                Rectangle wRect = new Rectangle();
                Rectangle cRect = new Rectangle();
                Native.GetWindowRect(Native.GetForegroundWindow(), out wRect);
                Native.GetClientRect(Native.GetForegroundWindow(), out cRect);
                textBox1.Text = wRect.Location.ToString();
                textBox2.Text = (wRect.Width - wRect.X).ToString();
                textBox3.Text = (wRect.Height - wRect.Y).ToString();
                textBox4.Text = cRect.Size.ToString();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        void t_Tick(object sender, EventArgs e)
        {
            if (Native.GetHwnds("Atlantica").Contains(Native.GetForegroundWindow()))
                //start_hook();
                hooked = true;
            else
                //stop_hook();
                hooked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Native.GetHwnd("Atlantica");
            if (hwnd != null)
            {
                Native.ShowWindow(hwnd, Native.SW_RESTORE);
                Native.SetForegroundWindow(hwnd);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            t.Start();
            start_hook();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!resize)
            {
                w = 258;
                h = 196;
                resize = true;
            }
            else
            {
                w = 1030;
                h = 784;
                resize = false;
            }
            Native.MoveWindow(Native.GetHwnd("Atlantica"), 0, 0, w, h, false);
        }

    }
}
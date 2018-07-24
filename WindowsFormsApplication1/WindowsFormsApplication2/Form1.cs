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
using gma.System.Windows;

namespace WindowsFormsApplication2
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
            WM_SETCURSOR = 0x0020,
            WM_MOUSEACTIVATE = 0x0021;


        Timer t = new Timer();
        IntPtr[] _list_hwnd = new IntPtr[0];
        int[] _list_pid = new int[0];
        long count = 0;
        int X = 100, Y = 100;
        IntPtr _hwnd = IntPtr.Zero;

        //UserActivityHook hook = new UserActivityHook();

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
            t.Interval = 2000;
            t.Tick += (s, e) => { dosomething(); };
            //hook.OnMouseActivity += hook_OnMouseActivity;
            //hook.KeyDown += hook_KeyDown;
        }

        //void hook_KeyDown(object sender, KeyEventArgs e)
        //{
        //    //if (e.KeyCode == Keys.F12)
        //    //{
        //    //    list_pos.Items.Add(new ListViewItem(new string[] { txt_x.Text, txt_y.Text }));
        //    //}
        //}

        //void hook_OnMouseActivity(object sender, MouseEventArgs e)
        //{
        //    //txt_x.Text = e.X.ToString();
        //    //txt_y.Text = e.Y.ToString();
        //    //txt_x_hex.Text = Convert.ToString(e.X, 16).ToUpper().PadLeft(4, '0');
        //    //txt_y_hex.Text = Convert.ToString(e.Y, 16).ToUpper().PadLeft(4, '0');
        //}

        private void Form1_Shown(object sender, EventArgs e)
        {
            _hwnd = Process.GetProcessesByName("Atlantica").FirstOrDefault().MainWindowHandle;
            //hook.Start();
            list_pos.Items.Add(new ListViewItem(new string[] { Convert.ToString(117, 16).PadLeft(4, '0'), Convert.ToString(324, 16).PadLeft(4, '0') }));
            list_pos.Items.Add(new ListViewItem(new string[] { Convert.ToString(201, 16).PadLeft(4, '0'), Convert.ToString(605, 16).PadLeft(4, '0') }));
            list_pos.Items.Add(new ListViewItem(new string[] { Convert.ToString(448, 16).PadLeft(4, '0'), Convert.ToString(581, 16).PadLeft(4, '0') }));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t.Enabled)
            {
                //btn_refresh.Visible = true;
                t.Enabled = false;
                t.Stop();
                btn_spam.Text = "Spam";
                btn_spam.BackColor = Color.Lime;
                //lbl_count.Text = "Count : ";
            }
            else
            {
                //_list_hwnd = get_hwnd();
                //if (_list_hwnd.Length > 0)
                //{
                //    count = 0;
                //    btn_refresh.Visible = false;
                //X = 100;
                //Y = 100;
                t.Enabled = true;
                t.Start();
                btn_spam.Text = "Stop";
                btn_spam.BackColor = Color.Red;
                //}
            }
        }

        private void dosomething()
        {
            #region comment

            //int pos1 = 0, pos2 = 0, pos3 = 0;
            //pos1 = Convert.ToInt32(list_pos.Items[0].SubItems[0].Text + list_pos.Items[0].SubItems[1].Text, 16);
            //pos2 = Convert.ToInt32(list_pos.Items[1].SubItems[0].Text + list_pos.Items[1].SubItems[1].Text, 16);
            //pos3 = Convert.ToInt32(list_pos.Items[2].SubItems[0].Text + list_pos.Items[2].SubItems[1].Text, 16);

            //string a = Convert.ToString(Convert.ToInt32(list_pos.Items[0].SubItems[1].Text), 16).PadLeft(4, '0');
            //string b = Convert.ToString(Convert.ToInt32(list_pos.Items[0].SubItems[0].Text), 16).PadLeft(4, '0');
            //pos1 = Convert.ToInt32(a + b, 16);

            //SendMessage(_hwnd, WM_SETCURSOR, _hwnd.ToInt32(), 33554433);
            //SendMessage(_hwnd, WM_MOUSEMOVE, 0, pos1);
            //PostMessage(_hwnd, WM_LBUTTONDOWN, 1, pos1);
            //PostMessage(_hwnd, WM_LBUTTONUP, 0, pos1);

            //System.Threading.Thread.Sleep(500);
            //PostMessage(_hwnd, WM_LBUTTONDOWN, 1, pos2);
            //PostMessage(_hwnd, WM_LBUTTONUP, 0, pos2);
            //System.Threading.Thread.Sleep(500);
            //PostMessage(_hwnd, WM_LBUTTONDOWN, 1, pos3);
            //PostMessage(_hwnd, WM_LBUTTONUP, 0, pos3);
            //System.Threading.Thread.Sleep(500);
            

            //int pos1 = Convert.ToInt32("01F401F4", 16);
            //int pos1 = Convert.ToInt32(list_pos.Items[0].SubItems[1].Text + list_pos.Items[0].SubItems[0].Text, 16);
            //int pos2 = Convert.ToInt32(list_pos.Items[1].SubItems[1].Text + list_pos.Items[1].SubItems[0].Text, 16);
            //int pos3 = Convert.ToInt32(list_pos.Items[2].SubItems[1].Text + list_pos.Items[2].SubItems[0].Text, 16);

            //PostMessage(_hwnd, WM_MOUSEMOVE, IntPtr.Zero, new IntPtr(pos1));
            //SendMessage(_hwnd, WM_MOUSEACTIVATE, new IntPtr(Convert.ToInt32("00100628", 16)), new IntPtr(Convert.ToInt32("02010001", 16)));
            //PostMessage(_hwnd, WM_LBUTTONDOWN, new IntPtr(1), new IntPtr(pos1));
            //PostMessage(_hwnd, WM_LBUTTONUP, IntPtr.Zero, new IntPtr(pos1));
            //new System.Threading.ManualResetEvent(false).WaitOne(500);

            //PostMessage(_hwnd, WM_MOUSEMOVE, IntPtr.Zero, new IntPtr(pos2));
            //SendMessage(_hwnd, WM_MOUSEACTIVATE, new IntPtr(Convert.ToInt32("00100628", 16)), new IntPtr(Convert.ToInt32("02010001", 16)));
            //PostMessage(_hwnd, WM_LBUTTONDOWN, new IntPtr(1), new IntPtr(pos2));
            //PostMessage(_hwnd, WM_LBUTTONUP, IntPtr.Zero, new IntPtr(pos2));
            //new System.Threading.ManualResetEvent(false).WaitOne(500);

            //PostMessage(_hwnd, WM_MOUSEMOVE, IntPtr.Zero, new IntPtr(pos3));
            //SendMessage(_hwnd, WM_MOUSEACTIVATE, new IntPtr(Convert.ToInt32("00100628", 16)), new IntPtr(Convert.ToInt32("02010001", 16)));
            //PostMessage(_hwnd, WM_LBUTTONDOWN, new IntPtr(1), new IntPtr(pos3));
            //PostMessage(_hwnd, WM_LBUTTONUP, IntPtr.Zero, new IntPtr(pos3));
            //new System.Threading.ManualResetEvent(false).WaitOne(500);
            //txt_x.Text = X.ToString();
            //txt_y.Text = Y.ToString();
            //txt_x_hex.Text = Convert.ToString(X, 16).ToUpper().PadLeft(4, '0');
            //txt_y_hex.Text = Convert.ToString(Y, 16).ToUpper().PadLeft(4, '0');
            //X += 10;
            //Y += 10;

            #endregion comment

            string[] pos = new string[3];
            pos[0] = list_pos.Items[0].SubItems[1].Text + list_pos.Items[0].SubItems[0].Text;
            pos[1] = list_pos.Items[1].SubItems[1].Text + list_pos.Items[1].SubItems[0].Text;
            pos[2] = list_pos.Items[2].SubItems[1].Text + list_pos.Items[2].SubItems[0].Text;
            clickOnPosition(pos);
        }

        private void clickOnPosition(string[] pos)
        {
            if (pos.Length > 0)
            {
                foreach (string s in pos)
                {
                    var _lParam = new IntPtr(Convert.ToInt32(s, 16));
                    PostMessage(_hwnd, WM_MOUSEMOVE, IntPtr.Zero, _lParam);
                    SendMessage(_hwnd, WM_MOUSEACTIVATE, new IntPtr(Convert.ToInt32("00100628", 16)), new IntPtr(Convert.ToInt32("02010001", 16)));
                    PostMessage(_hwnd, WM_LBUTTONDOWN, new IntPtr(1), _lParam);
                    PostMessage(_hwnd, WM_LBUTTONUP, IntPtr.Zero, _lParam);
                    new System.Threading.ManualResetEvent(false).WaitOne(500);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //list_pos.Items.Clear();
        }

        private void btn_pos_1_Click(object sender, EventArgs e)
        {
            clickOnPosition(new string[] { pos_y_1_h.Text + pos_x_1_h.Text });
        }

        private void btn_pos_2_Click(object sender, EventArgs e)
        {
            clickOnPosition(new string[] { pos_y_2_h.Text + pos_x_2_h.Text });
        }

        private void btn_pos_3_Click(object sender, EventArgs e)
        {
            clickOnPosition(new string[] { pos_y_3_h.Text + pos_x_3_h.Text });
        }

        private void pos_x_1_ValueChanged(object sender, EventArgs e)
        {
            pos_x_1_h.Text = Convert.ToString(Convert.ToInt32(pos_x_1.Value), 16).PadLeft(4, '0');
        }

        private void pos_y_1_ValueChanged(object sender, EventArgs e)
        {
            pos_y_1_h.Text = Convert.ToString(Convert.ToInt32(pos_y_1.Value), 16).PadLeft(4, '0');
        }

        private void pos_x_2_ValueChanged(object sender, EventArgs e)
        {
            pos_x_2_h.Text = Convert.ToString(Convert.ToInt32(pos_x_2.Value), 16).PadLeft(4, '0');
        }

        private void pos_y_2_ValueChanged(object sender, EventArgs e)
        {
            pos_y_2_h.Text = Convert.ToString(Convert.ToInt32(pos_y_2.Value), 16).PadLeft(4, '0');
        }

        private void pos_x_3_ValueChanged(object sender, EventArgs e)
        {
            pos_x_3_h.Text = Convert.ToString(Convert.ToInt32(pos_x_3.Value), 16).PadLeft(4, '0');
        }

        private void pos_y_3_ValueChanged(object sender, EventArgs e)
        {
            pos_y_3_h.Text = Convert.ToString(Convert.ToInt32(pos_y_3.Value), 16).PadLeft(4, '0');
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Rectangle wRect = new Rectangle();
        //    GetWindowRect(_hwnd, ref wRect);

        //    Rectangle cRect = new Rectangle();
        //    GetClientRect(_hwnd, ref cRect);

        //    richTextBox1.Text += wRect.ToString();
        //    richTextBox1.Text += cRect.ToString();
        //    int borderWidth = ((wRect.Right - wRect.Left) - (cRect.Right - cRect.Left)) / 2;
        //    richTextBox1.Text += borderWidth.ToString();

        //    this.Text = wRect.Size.ToString();
        //}

    }
}

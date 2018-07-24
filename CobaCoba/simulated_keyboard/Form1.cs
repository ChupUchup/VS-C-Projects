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

namespace simulated_keyboard
{
    public partial class Form1 : Form
    {
        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;
        const int WM_CHAR = 0x0102;

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr hwnd = Process.GetProcessesByName("Atlantica").FirstOrDefault().MainWindowHandle;
            SendMessage(hwnd, WM_KEYDOWN, 0, 0);
            SendMessage(hwnd, WM_CHAR, 32, 0);
            SendMessage(hwnd, WM_KEYUP, 0, 0);
        }
    }
}

//using System.Threading.Tasks;
//using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Win32API
{
    public class Native
    {
        #region variables

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        public static uint
            w_down = 0x00000047,
            w_ch = 0x00000067,
            w_up = 0x00000047,
            l_down = 0x00220001,
            l_ch = 0x00220001,
            l_up = 0xC0220001,

            SW_MAXIMIZE = 0x0003,
            SW_MINIMIZE = 0x0006,
            SW_HIDE = 0x0000,
            SW_SHOW = 0x0005,
            SW_RESTORE = 0x0009,

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
        

        #endregion variables

        #region method

        [DllImport("User32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT rect);
        
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rectangle rect);

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, out RECT rect);

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, out  Rectangle rect);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("User32.dll")]
        public static extern bool MoveWindow(IntPtr handle, int x, int y, int width, int height, bool redraw);

        //[DllImport("user32.dll")]
        //public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);

        //[DllImport("user32.dll")]
        //public static extern IntPtr GetActiveWindow();

        //[DllImport("user32.dll")]
        //public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        public static IntPtr GetHwnd(string processName)
        {
            return Process.GetProcessesByName(processName).FirstOrDefault().MainWindowHandle;
        }

        public static IntPtr GetHwnd(int processId)
        {
            return Process.GetProcessById(processId).MainWindowHandle;
        }

        public static IntPtr[] GetHwnds(string processName)
        {
            Process[] proc = Process.GetProcessesByName(processName);
            IntPtr[] hsl = new IntPtr[proc.Length];
            for (int i = 0; i < proc.Length; i++)
                hsl[i] = proc[i].MainWindowHandle;
            return hsl;
        }

        public static int GetPId(string processName)
        {
            return Process.GetProcessesByName(processName).FirstOrDefault().Id;
        }

        public static int[] GetPIds(string processName)
        {
            Process[] proc = Process.GetProcessesByName(processName);
            int[] hsl = new int[proc.Length];
            for (int i = 0; i < proc.Length; i++)
                hsl[i] = proc[i].Id;
            return hsl;
        }

        #endregion method
    }
}

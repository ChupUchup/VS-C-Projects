//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace sendkey
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}

using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace SendKeysToAnyApplication
{
    class Program
    {
        delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);
        [DllImport("user32.dll")]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);
        
        static IntPtr m_hWndEdit = new IntPtr(2622512);
        const uint WM_CHAR = 0x102;
        const uint WM_PASTE = 0x0302;

        #region coredll
        //const int KEYEVENTF_KEYDOWN = 0x0000;
        //const int KEYEVENTF_KEYUP = 0x0002;

        

        //[DllImport("coredll.dll")]
        //static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        //static void SendKey(Keys key)
        //{
        //    keybd_event((byte)key, 0, KEYEVENTF_KEYDOWN, 0);
        //    keybd_event((byte)key, 0, KEYEVENTF_KEYUP, 0);
        //}
        #endregion coredll

        #region keybd
        //[DllImport("user32.dll", SetLastError = true)]
        //static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);


        //public const int KEYDOWN = 0x0001; //Key down flag
        //public const int KEYUP = 0x0002; //Key up flag
        //public const int VK_LCONTROL = 0xA2; //Left Control key code
        //public const int A = 0x41; //A key code
        //public const int C = 0x43; //C key code

        //public static void PressKeys()
        //{
        //    // Hold Control down and press A
        //    keybd_event(VK_LCONTROL, 0, KEYDOWN, 0);
        //    keybd_event(A, 0, KEYDOWN, 0);
        //    keybd_event(A, 0, KEYUP, 0);
        //    keybd_event(VK_LCONTROL, 0, KEYUP, 0);

        //    // Hold Control down and press C
        //    keybd_event(VK_LCONTROL, 0, KEYDOWN, 0);
        //    keybd_event(C, 0, KEYDOWN, 0);
        //    keybd_event(C, 0, KEYUP, 0);
        //    keybd_event(VK_LCONTROL, 0, KEYUP, 0);
        //}

        //static void SendTabKey()
        //{
        //    SendKey(Keys.Tab);
        //}

        #endregion keybd

        #region sendmessage

        //[DllImport("User32.dll")]
        //private static extern bool SendMessage(int hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        //[DllImport("user32.dll")]
        //private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, String lpszClass, String lpszWindow);

        //public const Int32 WM_KEYDOWN = 0x0100;
        //public const Int32 WM_KEYUP = 0x0101;
        ////public const Int32 WM_CHAR = 0x0102;


        #endregion sendmessage


        [STAThread]
        static void Main(string[] args)
        {
            // for a test we use the notepad window
            // ... so lets have a look if we find an opened notepad window (better you open one first...)
            //IntPtr hWnd = FindWindow("form_uji", null);
            //IntPtr hWnd = Process.GetProcessesByName("form_uji").FirstOrDefault().MainWindowHandle;
            // But! we can not send text to the main-window, we have to find the subwindow where the text is entered
            // So lets enumerate all child windows:
            //IntPtr hWndEdit = IntPtr.Zero;
            //EnumChildWindows(hWnd, EnumChildWindowsCallback, hWndEdit);

            if (m_hWndEdit != null) // edit window found?
            {
                // Now you could use different messages to send text (WM_CHAR, WM_KEYDOWN, ...)
                // I decided to use the clipboard:
                // Copy some text to the clipboard
                //Clipboard.SetText("this is magic!");
                //// ... and just paste it to the target window
                //SendMessage(m_hWndEdit, WM_PASTE, 0, 0);

                //SendKey(Keys.Space);

                //SendMessage(Convert.ToInt32( m_hWndEdit), 0, 0, 0);
                //SendMessage(2622512, WM_KEYDOWN, new IntPtr(Convert.ToInt32(Keys.Space)), IntPtr.Zero);
            }
        }

        static bool EnumChildWindowsCallback(IntPtr hWnd, IntPtr lParam)
        {
            // Search for notepads edit window - if we find it "false" is returned (means stop enumerating windows)

            StringBuilder sb = new StringBuilder();
            GetClassName(hWnd, sb, 255);
            if (!sb.ToString().Contains("2bf8098_r11_ad1"))
            {
                return true;
            }
            m_hWndEdit = hWnd; // Store the handle to notepads edit window (this is the window we want to send the messages to)
            return false;
        }
    }
}

//backup origin
//using System;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Windows.Forms;

//namespace SendKeysToAnyApplication
//{
//    class Program
//    {
//        delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

//        [DllImport("user32.dll")]
//        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
//        [DllImport("user32.dll")]
//        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
//        [DllImport("user32.dll")]
//        static extern bool EnumChildWindows(IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);
//        [DllImport("user32.dll")]
//        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

//        const uint WM_CHAR = 0x102;
//        const uint WM_PASTE = 0x0302;

//        static IntPtr m_hWndEdit = IntPtr.Zero;

//        [STAThread]
//        static void Main(string[] args)
//        {
//            // for a test we use the notepad window
//            // ... so lets have a look if we find an opened notepad window (better you open one first...)
//            IntPtr hWnd = FindWindow("Notepad", null);
//            // But! we can not send text to the main-window, we have to find the subwindow where the text is entered
//            // So lets enumerate all child windows:
//            IntPtr hWndEdit = IntPtr.Zero;
//            EnumChildWindows(hWnd, EnumChildWindowsCallback, hWndEdit);

//            if (m_hWndEdit != null) // edit window found?
//            {
//                // Now you could use different messages to send text (WM_CHAR, WM_KEYDOWN, ...)
//                // I decided to use the clipboard:
//                // Copy some text to the clipboard
//                Clipboard.SetText("this is magic!");
//                // ... and just paste it to the target window
//                SendMessage(m_hWndEdit, WM_PASTE, 0, 0);
//            }
//        }

//        static bool EnumChildWindowsCallback(IntPtr hWnd, IntPtr lParam)
//        {
//            // Search for notepads edit window - if we find it "false" is returned (means stop enumerating windows)

//            StringBuilder sb = new StringBuilder();
//            GetClassName(hWnd, sb, 256);
//            if (!sb.ToString().Contains("Edit"))
//            {
//                return true;
//            }

//            m_hWndEdit = hWnd; // Store the handle to notepads edit window (this is the window we want to send the messages to)
//            return false;
//        }
//    }
//}

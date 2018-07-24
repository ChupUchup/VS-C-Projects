using System;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WndProcWrapper
{
    public class NativeMethod
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rectangle rect);

        [DllImport("user32.dll")]
        public static extern bool GetClientRect(IntPtr hWnd, out  Rectangle rect);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("User32.dll")]
        public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool redraw);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint uMsg, uint wParam, uint lParam);

        [DllImport("User32.dll")]
        public static extern int PostMessage(IntPtr hWnd, uint uMsg, uint wParam, uint lParam);

        [DllImport("User32.dll")]
        public static extern bool PostThreadMessage(int idThread, uint uMsg, uint wParam, uint lParam);

        [DllImport("User32.dll")]
        public static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hWnd);

        [DllImport("User32.dll")]
        public static extern IntPtr WindowFromPoint(Point point);

        [DllImport("User32.dll")]
        public static extern bool GetCursorPos(ref POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern bool ScreenToClient(IntPtr hWnd, ref POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern bool TranslateMessage(ref MSG lpMsg);

        [DllImport("user32.dll")]
        public static extern IntPtr DispatchMessage(ref MSG lpmsg);

        [DllImport("user32.dll")]
        public static extern bool GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool GetVolumeInformation(
          string rootPathName,
          StringBuilder volumeNameBuffer,
          uint volumeNameSize,
          out uint volumeSerialNumber,
          out uint maximumComponentLength,
          out FileSystemFeature fileSystemFlags,
          StringBuilder fileSystemNameBuffer,
          uint nFileSystemNameSize);
    }

    public enum NativeConst
    {
        HT_CAPTION = 0x2,
        //nCmdShow
        SW_FORCEMINIMIZE = 0x0011,
        SW_HIDE = 0x0000,
        SW_MAXIMIZE = 0x0003,
        SW_MINIMIZE = 0x0006,
        SW_RESTORE = 0x0009,
        SW_SHOW = 0x0005,
        SW_SHOWDEFAULT = 0x0010,
        SW_SHOWMAXIMIZED = 0x0003,
        SW_SHOWMINIMIZED = 0x0002,
        SW_SHOWMINNOACTIVE = 0x0007,
        SW_SHOWNA = 0x0008,
        SW_SHOWNOACTIVATE = 0x0004,
        SW_SHOWNORMAL = 0x0001,
        //Keyboard Input Notifications
        WM_ACTIVATE = 0x0006,
        WM_APPCOMMAND = 0x0319,
        WM_CHAR = 0x0102,
        WM_DEADCHAR = 0x0103,
        WM_HOTKEY = 0x0312,
        WM_KEYDOWN = 0x0100,
        WM_KEYUP = 0x0101,
        WM_KILLFOCUS = 0x0008,
        WM_SETFOCUS = 0x0007,
        WM_SYSDEADCHAR = 0x0107,
        WM_SYSKEYDOWN = 0x0104,
        WM_SYSKEYUP = 0x0105,
        WM_UNICHAR = 0x0109,
        //Mouse Input Notifications
        WM_CAPTURECHANGED = 0x0215,
        WM_LBUTTONDBLCLK = 0x0203,
        WM_LBUTTONDOWN = 0x0201,
        WM_LBUTTONUP = 0x0202,
        WM_MBUTTONDBLCLK = 0x0209,
        WM_MBUTTONDOWN = 0x0207,
        WM_MBUTTONUP = 0x0208,
        WM_MOUSEACTIVATE = 0x0021,
        WM_MOUSEHOVER = 0x02A1,
        WM_MOUSEHWHEEL = 0x020E,
        WM_MOUSELEAVE = 0x02A3,
        WM_MOUSEMOVE = 0x0200,
        WM_MOUSEWHEEL = 0x020A,
        WM_NCHITTEST = 0x0084,
        WM_NCLBUTTONDBLCLK = 0x00A3,
        WM_NCLBUTTONDOWN = 0x00A1,
        WM_NCLBUTTONUP = 0x00A2,
        WM_NCMBUTTONDBLCLK = 0x00A9,
        WM_NCMBUTTONDOWN = 0x00A7,
        WM_NCMBUTTONUP = 0x00A8,
        WM_NCMOUSEHOVER = 0x02A0,
        WM_NCMOUSELEAVE = 0x02A2,
        WM_NCMOUSEMOVE = 0x00A0,
        WM_NCRBUTTONDBLCLK = 0x00A6,
        WM_NCRBUTTONDOWN = 0x00A4,
        WM_NCRBUTTONUP = 0x00A5,
        WM_NCXBUTTONDBLCLK = 0x00AD,
        WM_NCXBUTTONDOWN = 0x00AB,
        WM_NCXBUTTONUP = 0x00AC,
        WM_RBUTTONDBLCLK = 0x0206,
        WM_RBUTTONDOWN = 0x0204,
        WM_RBUTTONUP = 0x0205,
        WM_XBUTTONDBLCLK = 0x020D,
        WM_XBUTTONDOWN = 0x020B,
        WM_XBUTTONUP = 0x020C,
        //Cursor Notifications
        WM_SETCURSOR = 0x0020,
        //WM Button Message
        MK_CONTROL = 0x0008,
        MK_LBUTTON = 0x0001,
        MK_MBUTTON = 0x0010,
        MK_RBUTTON = 0x0002,
        MK_SHIFT = 0x0004,
        MK_XBUTTON1 = 0x0020,
        MK_XBUTTON2 = 0x0040
    }

    public enum FileSystemFeature : uint
    {
        /// <summary>
        /// The file system preserves the case of file names when it places a name on disk.
        /// </summary>
        CasePreservedNames = 2,

        /// <summary>
        /// The file system supports case-sensitive file names.
        /// </summary>
        CaseSensitiveSearch = 1,

        /// <summary>
        /// The specified volume is a direct access (DAX) volume. This flag was introduced in Windows 10, version 1607.
        /// </summary>
        DaxVolume = 0x20000000,

        /// <summary>
        /// The file system supports file-based compression.
        /// </summary>
        FileCompression = 0x10,

        /// <summary>
        /// The file system supports named streams.
        /// </summary>
        NamedStreams = 0x40000,

        /// <summary>
        /// The file system preserves and enforces access control lists (ACL).
        /// </summary>
        PersistentACLS = 8,

        /// <summary>
        /// The specified volume is read-only.
        /// </summary>
        ReadOnlyVolume = 0x80000,

        /// <summary>
        /// The volume supports a single sequential write.
        /// </summary>
        SequentialWriteOnce = 0x100000,

        /// <summary>
        /// The file system supports the Encrypted File System (EFS).
        /// </summary>
        SupportsEncryption = 0x20000,

        /// <summary>
        /// The specified volume supports extended attributes. An extended attribute is a piece of
        /// application-specific metadata that an application can associate with a file and is not part
        /// of the file's data.
        /// </summary>
        SupportsExtendedAttributes = 0x00800000,

        /// <summary>
        /// The specified volume supports hard links. For more information, see Hard Links and Junctions.
        /// </summary>
        SupportsHardLinks = 0x00400000,

        /// <summary>
        /// The file system supports object identifiers.
        /// </summary>
        SupportsObjectIDs = 0x10000,

        /// <summary>
        /// The file system supports open by FileID. For more information, see FILE_ID_BOTH_DIR_INFO.
        /// </summary>
        SupportsOpenByFileId = 0x01000000,

        /// <summary>
        /// The file system supports re-parse points.
        /// </summary>
        SupportsReparsePoints = 0x80,

        /// <summary>
        /// The file system supports sparse files.
        /// </summary>
        SupportsSparseFiles = 0x40,

        /// <summary>
        /// The volume supports transactions.
        /// </summary>
        SupportsTransactions = 0x200000,

        /// <summary>
        /// The specified volume supports update sequence number (USN) journals. For more information,
        /// see Change Journal Records.
        /// </summary>
        SupportsUsnJournal = 0x02000000,

        /// <summary>
        /// The file system supports Unicode in file names as they appear on disk.
        /// </summary>
        UnicodeOnDisk = 4,

        /// <summary>
        /// The specified volume is a compressed volume, for example, a DoubleSpace volume.
        /// </summary>
        VolumeIsCompressed = 0x8000,

        /// <summary>
        /// The file system supports disk quotas.
        /// </summary>
        VolumeQuotas = 0x20
    }

    public struct POINT
    {
        public int x;
        public int y;
    }

    public struct MSG
    {
        public IntPtr hwnd;
        public uint message;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public POINT pt;
    }
}

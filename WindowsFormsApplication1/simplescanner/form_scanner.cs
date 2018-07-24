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

namespace simplescanner
{
    public partial class form_scanner : Form
    {
        int PROCESS_VM_READ = 0x0010, PROCESS_QUERY_LIMITED_INFORMATION = 0x1000;
        private form_process_list f_proc_list;
        public int proc_id = 0;
        public IntPtr proc_hWnd = IntPtr.Zero;
        IntPtr proc_start = IntPtr.Zero;
        int proc_size = 0;

        [DllImport("kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        static extern bool QueryFullProcessImageName([In]IntPtr hProcess, [In]int dwFlags, [Out]StringBuilder lpExeName, ref int lpdwSize);
        
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        public form_scanner()
        {
            InitializeComponent();
        }

        private void btn_target_Click(object sender, EventArgs e)
        {
            f_proc_list = new form_process_list();
            f_proc_list.Owner = this;
            f_proc_list.ShowDialog();
        }

        private void form_scanner_Shown(object sender, EventArgs e)
        {
            combo_scan_type.Items.AddRange(new string[] {
                "Byte",
                "String",
                "Short".PadRight(6,' ') + "[2 Bytes]".PadLeft(11,' '),
                "Char".PadRight(6,' ') + "[2 Bytes]".PadLeft(11,' '),
                "Integer".PadRight(7,' ') + "[4 Bytes]".PadLeft(10,' '),
                "Float".PadRight(6,' ') + "[4 Bytes]".PadLeft(11,' '),
                "Long".PadRight(6,' ') + "[8 Bytes]".PadLeft(11,' '),
                "Duble".PadRight(6,' ') + "[8 Bytes]".PadLeft(11,' '),
                "Decimal".PadRight(7,' ') + "[16 Bytes]".PadLeft(11,' ')
            });
            combo_scan_type.SelectedIndex = 2;
        }

        private void txt_target_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            Process p = Process.GetProcessesByName("Atlantica").FirstOrDefault();
            txt_start.Text = p.MainModule.BaseAddress.ToString();
        }
    }
}

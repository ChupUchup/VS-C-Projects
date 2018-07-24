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
    public partial class form_process_list : Form
    {
        int PROCESS_VM_READ = 0x0010;
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(int processAccess, bool bInheritHandle, int processId);

        public form_process_list()
        {
            InitializeComponent();
        }

        private void form_process_list_Shown(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses().OrderBy(x => x.ProcessName))
            {
                try
                {
                    //bool x = p.MainModule.FileVersionInfo.IsSpecialBuild;
                    list_process.Items.Add(new ListViewItem(new string[] { p.ProcessName, p.StartTime.ToShortTimeString(), p.Id.ToString(), p.MainWindowHandle.ToString()}));//OpenProcess(PROCESS_VM_READ, false, p.Id).ToString() }));
                }
                catch { }
            }
        }

        private void list_process_DoubleClick(object sender, EventArgs e)
        {
            if (list_process.SelectedItems.Count > 0)
            {
                ((form_scanner)this.Owner).proc_id = Convert.ToInt32(list_process.SelectedItems[0].SubItems[2].Text);
                ((form_scanner)this.Owner).proc_hWnd = new IntPtr(Convert.ToInt32(list_process.SelectedItems[0].SubItems[3].Text));
                ((form_scanner)this.Owner).txt_target.Text = list_process.SelectedItems[0].SubItems[0].Text;
                this.Close();
            }
        }
    }
}

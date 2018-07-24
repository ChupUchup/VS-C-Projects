using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32API;

namespace aotools
{
    public partial class form_target_process : Form
    {
        public form_target_process()
        {
            InitializeComponent();
        }

        private void form_target_process_Shown(object sender, EventArgs e)
        {
            foreach (int id in Native.GetPIds("Atlantica"))
            {
                System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(id);
                list_process.Items.Add(new ListViewItem(new string[] { p.ProcessName, p.StartTime.ToShortTimeString().ToString(), p.Id.ToString() }));
                if (((form_automouse)this.Owner)._list_hwnd.Contains(p.MainWindowHandle))
                    list_process.Items[list_process.Items.Count - 1].Checked = true;
            }
        }

        private void form_target_process_FormClosing(object sender, FormClosingEventArgs e)
        {
            IntPtr[] tmp = new IntPtr[0];
            for (int i = 0; i < list_process.Items.Count; i++)
            {
                if (list_process.Items[i].Checked)
                {
                    Array.Resize(ref tmp, tmp.Length + 1);
                    tmp[tmp.GetUpperBound(0)] = System.Diagnostics.Process.GetProcessById(Convert.ToInt32(list_process.Items[i].SubItems[2].Text)).MainWindowHandle;
                }
            }
            ((form_automouse)this.Owner)._list_hwnd = tmp;
        }
    }
}

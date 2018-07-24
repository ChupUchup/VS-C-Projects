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

namespace aotools
{
    public partial class form_autokeyboard : Form
    {
        public form_autokeyboard()
        {
            InitializeComponent();
        }

        private void form_autokeyboard_Shown(object sender, EventArgs e)
        {
            refresh_process_list();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh_process_list();
        }

        void refresh_process_list()
        {
            listView1.Items.Clear();
            foreach (Process p in Process.GetProcesses().Where(a => a.ProcessName.ToUpper().Contains(textBox1.Text.ToUpper())).OrderBy(a => a.ProcessName))
            {
                try
                {
                    listView1.Items.Add(new ListViewItem(new string[] { p.ProcessName, p.StartTime.ToShortTimeString(), p.Id.ToString() }));
                }
                catch
                {
                    //listView1.Items.Add(new ListViewItem(new string[] { p.ProcessName, "", p.Id.ToString() }));
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                refresh_process_list();
        }
    }
}

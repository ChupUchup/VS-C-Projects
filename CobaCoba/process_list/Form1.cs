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
using System.Reflection;

namespace process_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Process> proc = Process.GetProcesses().OrderBy(o => o.ProcessName).ToList();
            foreach (Process p in proc)
            {
                listBox1.Items.Add(p.ProcessName.ToString().PadRight(30, ' ') + "- " + p.Id);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = (ListBox)sender;
            int pid = Convert.ToInt32(l.Items[l.SelectedIndex].ToString().Split('-')[1].Trim());
            Process p = Process.GetProcessById(pid);
            IntPtr start = p.MainModule.BaseAddress;
            IntPtr end = IntPtr.Add(start, p.MainModule.ModuleMemorySize);
            txt_start_offset.Text = start.ToString("x8");
            txt_end_offset.Text = end.ToString("x8");
            txt_panjang_offset.Text = p.MainModule.ModuleMemorySize.ToString();

            #region comment
            //var bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
            //var fieldValues = p.GetType().GetFields(bindingFlags).Select(field => field.GetValue(p)).ToList();
            //foreach (object o in fieldValues)
            //{
            //    if (o != null)
            //        richTextBox2.Text += (o.ToString() + "\n");
            //    else
            //        richTextBox2.Text += ("null\n");
            //}
            //var fieldNames = typeof(Process).GetFields(bindingFlags)
            //                .Select(field => field.Name)
            //                .ToList();
            //foreach (object o in fieldNames)
            //{
            //    //if (o != null)
            //    richTextBox1.Text += (o.ToString() + "\n");
            //}
            #endregion comment
        }

        
    }
}

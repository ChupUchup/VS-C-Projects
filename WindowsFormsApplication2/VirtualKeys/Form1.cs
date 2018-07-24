using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            foreach (var k in Enum.GetValues(typeof(Keys)))
            {
                listView1.Items.Add(new ListViewItem(new string[] { k.ToString(), ((int)k).ToString("X"), ((int)k).ToString() }));
            }
            foreach (var k in Enum.GetValues(typeof(ConsoleKey)))
            {
                listView2.Items.Add(new ListViewItem(new string[] { k.ToString(), ((int)k).ToString("X"), ((int)k).ToString() }));
            }
        }
    }
}

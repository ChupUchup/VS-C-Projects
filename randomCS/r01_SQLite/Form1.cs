//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.IO;
using System.Windows.Forms;

namespace r01_SQLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            coba();
        }

        void coba()
        {
            listBox1.Items.AddRange(Enum.GetNames(typeof(System.Environment.SpecialFolder)));
            //listBox2.Items.AddRange(Enum.GetValues(typeof(System.Environment.SpecialFolder)));
            foreach (System.Environment.SpecialFolder i in Enum.GetValues(typeof(System.Environment.SpecialFolder)))
            {
                listBox2.Items.Add(i);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r04_progressBar
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            bw.DoWork += delegate { };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }
    }
}

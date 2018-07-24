using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HM_Gift
{
    public partial class Form_InputData : Form
    {
        public Form_InputData()
        {
            InitializeComponent();
        }
        private string dataname = "HM_Gift.txt";
        private List<string> data_gift = new List<string>();
        Fungsi fungsi = new Fungsi();

        private void Form_InputData_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            data_gift = fungsi.Reader(dataname);
            fungsi.Tampil(data_gift, richTextBox1);
        }

    }
}

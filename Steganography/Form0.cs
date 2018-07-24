using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class Form0 : Form
    {
        Form1 formLSB;

        public Form0()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lSBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLSB = new Form1();
            formLSB.MdiParent = this;
            formLSB.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r06_testForm
{
    public partial class Form0 : Form
    {
        Form1 waitAsync;
        Form2 drawAsync;

        public Form0()
        {
            InitializeComponent();
            this.Load += delegate
            {
                this.Location = new Point(0, 0);
            };
        }

        private void waitAsyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            waitAsync = new Form1();
            waitAsync.MdiParent = this;
            waitAsync.Show();
        }

        private void drawAsyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawAsync = new Form2();
            drawAsync.MdiParent = this;
            drawAsync.Show();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
                f.Dispose();
            }
        }
    }
}

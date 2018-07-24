using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace r09_drawing
{
    public partial class Form1 : Form
    {
        Graphics g;
        int w = 30;
        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromHwnd(this.Handle);
        }

        private void numStartSweep_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            g.DrawEllipse(Pens.Black, 100, 100, w, w);
            g.FillPie(Brushes.Red, 100, 100, w, w, (int)numStart1.Value, (int)numSweep1.Value);
            g.FillPie(Brushes.Green, 100, 100, w, w, (int)numStart2.Value, (int)numSweep2.Value);
            g.FillPie(Brushes.Blue, 100, 100, w, w, (int)numStart3.Value, (int)numSweep3.Value);
        }
    }
}

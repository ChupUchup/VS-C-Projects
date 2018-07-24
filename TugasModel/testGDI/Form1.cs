using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FungsiParabola;

namespace testGDI
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void newCanvas()
        {
            pictBox.Image = new Bitmap(pictBox.Width, pictBox.Height);
            g = Graphics.FromImage(pictBox.Image);
        }
        private void btnSin_Click(object sender, EventArgs e)
        {
            newCanvas();
            int x = pictBox.Width, y = pictBox.Height, x2 = x / 2, y2 = y / 2;
            g.DrawLine(Pens.Black, 0, y2, x, y2);
            for (int i = 0; i <= 360; i++)
            {
                g.FillRectangle(Brushes.Red, i, y2 - Convert.ToInt32(Parabola.mySin(i)*100), 1, 1);
                Thread.Sleep(10);
                pictBox.Refresh();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            newCanvas(); var watch = System.Diagnostics.Stopwatch.StartNew();
            int x = pictBox.Width, y = pictBox.Height, x2 = x / 2, y2 = y / 2;
            g.DrawLine(Pens.Black, 0, y2, x, y2);
            for (int i = 0; i <= 360; i++)
            {
                g.FillRectangle(Brushes.Red, i, y2 - Convert.ToInt32(Parabola.myCos(i) * 100), 1, 1);
                Thread.Sleep(1);
                pictBox.Refresh();
            } watch.Stop(); btnCos.Text = watch.ElapsedMilliseconds.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            newCanvas();
        }
    }
}

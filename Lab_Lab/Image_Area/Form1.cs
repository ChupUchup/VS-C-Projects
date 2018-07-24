using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLib;

namespace Image_Area
{
    public partial class Form1 : Form
    {
        Bitmap img1;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            img1 = Draw.GetImg();
            if (img1.Width > this.Width)
            {
                int wwidth = img1.Width - this.Width;
                this.Width += wwidth;
                this.ClientSize = new Size(this.ClientSize.Width + wwidth, this.ClientSize.Height);
                pictureBox1.Width += wwidth;
            }
            if (img1.Height > this.Height)
            {
                int hheight = img1.Height - this.Height;
                this.Height += hheight;
                this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height + hheight);
                pictureBox1.Height += hheight;
            }
            this.Invalidate();
            Draw.DrawScaledImg(pictureBox1, img1);
            //Draw.DrawScaledImg(pictureBox1, Draw.GetImg());
        }
    }
}

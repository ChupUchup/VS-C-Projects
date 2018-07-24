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

namespace SaltAndPepper_Noise
{
    public partial class Form1 : Form
    {
        Bitmap img1, img2;
        List<Color> myPixel = new List<Color>();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            img1 = Draw.GetImg();
            if (img1 != null)
            {
                Draw.DrawScaledImg(pictureBox1, img1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                img_to_array(img1, ref myPixel);
                add_noise(ref myPixel);
                Draw.DrawScaledImg(pictureBox2, array_to_img(ref myPixel));
            }
        }

        private void img_to_array(Bitmap img, ref List<Color> pix)
        {
            pix.Clear();
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    pix.Add(img.GetPixel(j, i));
                }
            }
        }

        private Bitmap array_to_img(ref List<Color> pix)
        {
            Bitmap img = new Bitmap(img1.Width, img1.Height);
            int count = 0;
            if (pix.Count > 0)
            {
                for (int i = 0; i < img1.Height; i++)
                {
                    for (int j = 0; j < img1.Width; j++)
                    {
                        img.SetPixel(j, i, pix[count]);
                        count++;
                    }
                }
            }
            return img;
        }

        private void add_noise(ref List<Color> pix)
        {
            if (numericUpDown1.Value > 0)
            {
                int persennoise = (int)numericUpDown1.Value;
                int totpixel = pix.Count();
                int totnoise = (int)(persennoise * 0.01 * totpixel);
                Random rnd = new Random();
                List<int> noisemap = new List<int>();
                int count = 0;
                do
                {
                    int now = rnd.Next(totpixel);
                    if (!(noisemap.Contains(now)))
                    {
                        int saltorpepper = rnd.Next(1000);
                        if (saltorpepper < 500) pix[now] = Color.FromArgb(0, 0, 0);
                        else pix[now] = Color.FromArgb(255, 255, 255);
                        noisemap.Add(now);
                        count++;
                    }
                } while (count < totnoise - 1);
            }
        }
    }
}

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
using System.Diagnostics;

namespace r06_testForm
{
    public partial class Form1 : Form
    {
        Stopwatch st;

        public Form1()
        {
            InitializeComponent();
            st = new Stopwatch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Status : ";
            progressBar1.Value = 0;
            test();
        }

        async void test()
        {
            st.Reset(); st.Start();
            Bitmap b=  await Task.Run(() => hitung());
            this.BackgroundImage = b;
        }

        Bitmap hitung()
        {
            int mH = 100, mW = 1000;
            Bitmap img = new Bitmap(mW, mH);
            for (int h = 0; h < mH; h++)
            {
                for (int w = 0; w < mW; w++)
                {
                    Random r = new Random();
                    img.SetPixel(w, h, Color.FromKnownColor((KnownColor)r.Next(1, mH)));
                    
                }
                Invoke((Action)delegate
                {
                    progressBar1.Value = h + 1;
                    if (h == mH - 1)
                    {
                        label1.Text = "Status : Done";
                        st.Stop();
                        label2.Text = "Time : " + st.Elapsed.ToString();
                    }
                });
            }
            return img;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace r07_asyncWait
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        Task<string> demo()
        {
            string content = "";
            return Task<string>.FromResult(content);
        }

        Task<TimeSpan> demo1()
        {
            Stopwatch st = new Stopwatch();
            Bitmap sample = new Bitmap(5000, 1000);
            int mW = sample.Width, mH = sample.Height;
            st.Start();
            for (int h = 0; h < mH; h++)
            {
                for (int w = 0; w < mW; w++)
                {
                    sample.SetPixel(w, h, Color.Red);
                }
            }
            st.Stop();
            return Task<TimeSpan>.FromResult(st.Elapsed);
        }

        TimeSpan demo2()
        {
            Stopwatch st = new Stopwatch();
            Bitmap sample = new Bitmap(5000, 1000);
            Color tmp;
            int mW = sample.Width, mH = sample.Height;
            st.Start();
            for (int h = 0; h < mH; h++)
            {
                for (int w = 0; w < mW; w++)
                {
                    tmp = sample.GetPixel(w, h);
                }
            }
            st.Stop();
            return st.Elapsed;
        }

        async void demo3()
        {
            string x = await Task.Run(() =>
            {
                Stopwatch st = new Stopwatch();
                Bitmap sample = new Bitmap(5000, 1000);
                Color tmp;
                int mW = sample.Width, mH = sample.Height;
                st.Start();
                for (int h = 0; h < mH; h++)
                {
                    for (int w = 0; w < mW; w++)
                    {
                        tmp = sample.GetPixel(w, h);
                    }
                }
                st.Stop();
                return st.Elapsed.ToString();
            });
            label3.Text = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string h = demo().Result;
            label1.Text = demo1().Result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TimeSpan i = Task<TimeSpan>.Factory.StartNew(() => demo2()).Result;
            //int j = Task<int>.Factory.StartNew(() => { return demo2(); }).Result;
            label2.Text = Task<TimeSpan>.Factory.StartNew(() => demo2()).Result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            demo3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}

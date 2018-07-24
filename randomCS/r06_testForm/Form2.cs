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

namespace r06_testForm
{
    public partial class Form2 : Form
    {
        Stopwatch st;
        bool isCleaning, isDrawing;
        IntPtr h;
        Timer t;

        public Form2()
        {
            InitializeComponent();
            h = pictureBox1.Handle;
            t = new Timer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isDrawing = true;
            draw1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isDrawing = true;
            draw2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isCleaning) isCleaning = false;
            else
            {
                isCleaning = true;
                clean();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isDrawing) isDrawing = false;
            else isDrawing = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (t.Enabled) t.Enabled = false;
            else testTimer();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            t.Interval = (int)numericUpDown1.Value;
        }

        async void draw1()
        {
            int min = 0,
                max = pictureBox1.Width / 2;
            await Task.Run(() =>
            {
                drawEllipse(Graphics.FromHwnd(h), min, max);
            });
        }

        async void draw2()
        {
            int min = pictureBox1.Width / 2,
                max = pictureBox1.Width;
            await Task.Run(() =>
            {
                drawEllipse(Graphics.FromHwnd(h), min, max);
            });
        }

        async void clean()
        {
            
            await Task.Run(() =>
            {
                cleanSurface(Graphics.FromHwnd(h));
            });
        }

        void drawEllipse(Graphics g, int min, int max)
        {
            Random rnd = new Random();
            long count = 0;
            do
            {
                if (count % 100 == 0)
                {
                    Point loc = new Point(rnd.Next(min, max), rnd.Next(0, pictureBox1.Height));
                    g.DrawEllipse(Pens.Red, new Rectangle(loc, new Size(10, 10)));
                }
                count++;
            } while (isDrawing);
        }

        void cleanSurface(Graphics g)
        {
            st = new Stopwatch();

            st.Reset();
            st.Start();
            do
            {
                if (st.ElapsedMilliseconds % 500 == 0)
                {
                    g.Clear(Color.Transparent);
                }
            } while (isCleaning);
            st.Stop();
        }

        void testTimer()
        {
            t.Interval = (int)numericUpDown1.Value;
            Graphics g = Graphics.FromHwnd(h);
            int x = 0, y = 0, stepX = 10, stepY = 10;

            t.Tick += delegate
            {
                if (x >= pictureBox1.Width - 5) stepX = -10;
                else if (x <= 5) stepX = 10;
                if (y >= pictureBox1.Height - 5) stepY = -10;
                else if (y <= 5) stepY = 10;

                g.Clear(Color.Transparent);
                g.DrawEllipse(Pens.Red, x, y, 10, 10);
                //g.FillEllipse(Brushes.Red, x, y, 10, 10);

                x += stepX;
                y += stepY;
            };
            t.Enabled = true;
        }

        
    }
}

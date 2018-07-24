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
using System.Windows;
using Microsoft.Win32;

namespace r08_cpuProcess
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        PerformanceCounter[] perf = new PerformanceCounter[3];
        Graphics g;
        Font f;
        bool isHiden = false;
        public Form1()
        {
            InitializeComponent();
            Color c1 = Color.FromArgb(255, 0, 255, 0);
            Color c2 = Color.FromArgb(255, 1, 1, 1);
            Color c3 = Color.FromArgb(255, 255, 0, 0);
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            this.BackColor = c2;
            this.TransparencyKey = c2;
            this.AllowTransparency = true;
            this.TopMost = true;
            this.TopLevel = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            //this.Size = new System.Drawing.Size(57, 31);

            SolidBrush b = new SolidBrush(c1);
            g = Graphics.FromHwnd(this.Handle);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            f = new System.Drawing.Font(new FontFamily("Consolas"), 8);
            t.Interval = 1000;

            perf[0] = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            perf[1] = new PerformanceCounter("Memory", "% Committed Bytes In Use", null);
            perf[2] = new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            t.Tick += delegate
            {
                float[] pf = { 
                                 perf[0].NextValue(), 
                                 perf[1].NextValue(), 
                                 perf[2].NextValue()};
                for (int i = 0; i < 3; i++)
                {
                    if (pf[i] > 100) pf[i] = 100;
                }
                //cara 3
                g.Clear(c2);
                //g.FillRectangle(Brushes.LightGray, 0, 0, 50, 2);
                //g.FillRectangle(Brushes.LightGray, 0, 3, 50, 2);
                //g.FillRectangle(Brushes.LightGray, 0, 6, 50, 2);
                int count = 0;
                foreach (var i in pf)
                {
                    if (i > 75) b = new SolidBrush(c3);
                    else b = new SolidBrush(c1);
                    g.FillRectangle(b, 0, count, (int)i / 2, 2);
                    count += 3;
                }

                /* cara 2
                progressBar1.Value = (int)pf[0];
                progressBar2.Value = (int)pf[1];
                progressBar3.Value = (int)pf[2];
                */
                /* cara 1
                string[] s = {
                                 "C" + pf[0].ToString("0.00").PadLeft(6) + " %",
                                 "M" + pf[1].ToString("0.00").PadLeft(6) + " %",
                                 "D" + pf[2].ToString("0.00").PadLeft(6) + " %"};
                g.Clear(c2);
                int count = 0, y = 0;
                foreach (string ss in s)
                {
                    if (pf[count] > 75) b = new SolidBrush(c3);
                    else b = new SolidBrush(c1);
                    g.DrawString(s[count], f, b, new PointF(0, y));
                    count++;
                    y += 10;
                }
                 */
            };
            this.Shown += delegate
            {
                this.Location = new Point(0, 0);
                t.Enabled = true;
                if (rk.GetValueNames().Contains("Perf"))
                {
                    startupToolStripMenuItem.Checked = true;
                }
                else
                {
                    startupToolStripMenuItem.Checked = false;
                }
            };
            notifyIcon1.DoubleClick += delegate
            {
                if (isHiden)
                {
                    this.Show();
                    isHiden = false;
                }
                else
                {
                    this.Hide();
                    isHiden = true;
                }
            };
            startupToolStripMenuItem.Click += delegate
            {
                if (startupToolStripMenuItem.Checked)
                {
                    rk.SetValue("Perf", Application.ExecutablePath);
                }
                else
                {
                    rk.DeleteValue("Perf", false);
                }
            };
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

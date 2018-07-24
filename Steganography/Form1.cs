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

namespace Steganography
{
    public partial class Form1 : Form
    {
        Bitmap img1, img2;
        Stopwatch st;

        public Form1()
        {
            InitializeComponent();
            st = new Stopwatch();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lblEmbedCount.Text = "Embed Count : " + richTextBox1.TextLength.ToString();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            lblExtractCount.Text = "Extract Count : " + richTextBox2.TextLength.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName != "")
                    {
                        img1 = new Bitmap(ofd.FileName);
                        pictureBox1.Image = Pixel.ScaledBitmap(img1, pictureBox1.Size);
                        lblEmbedMax.Text = "Max Embed : " + (((img1.Width * img1.Height * 3) - 32) / 8).ToString();
                    }
                }
            }
        }

        private void btnEmbed_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                doEmbed();
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (img2 != null)
            {
                doExtract();
            }
        }

        async void doEmbed()
        {
            try
            {
                progressBarEmbed.Value = 0;
                btnBrowse.Enabled = false;
                btnEmbed.Enabled = false;
                btnExtract.Enabled = false;
                btnEmbed.Text = "Proces...";
                st.Reset();
                st.Start();
                string msg = richTextBox1.Text;

                img2 = await Task.Run(() => LSB.Embed(img1, msg));

                pictureBox2.Image = Pixel.ScaledBitmap(img2, pictureBox2.Size);
                lblEmbed.Text = "Embed Time : " + st.Elapsed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnBrowse.Enabled = true;
                btnExtract.Enabled = true;
                btnEmbed.Enabled = true;
                btnEmbed.Text = "Embed";
                st.Stop();
            }
        }

        async void doExtract()
        {
            try
            {
                progressBarExtract.Value = 0;
                btnBrowse.Enabled = false;
                btnEmbed.Enabled = false;
                btnExtract.Enabled = false;
                btnExtract.Text = "Proces...";
                st.Reset();
                st.Start();

                string msg = await Task.Run(() => LSB.Extract(img2));

                richTextBox2.Text = msg;
                lblExtract.Text = "Extract Time : " + st.Elapsed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnBrowse.Enabled = true;
                btnExtract.Enabled = true;
                btnEmbed.Enabled = true;
                btnExtract.Text = "Embed";
                st.Stop();
            }
        }
    }
}
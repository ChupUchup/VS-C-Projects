using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using myLib;

namespace Stegano_Lab
{
    public partial class Form1 : Form
    {
        Bitmap img1, img2, img3;
        Series shisto_S = new Series(), shisto_E = new Series();
        public Form1()
        {
            InitializeComponent();
            Kanvas_Sisip.Image = new Bitmap(Kanvas_Sisip.Width, Kanvas_Sisip.Height);
            Kanvas_Hsl.Image = new Bitmap(Kanvas_Hsl.Width, Kanvas_Hsl.Height);
            Kanvas_Ekstrak.Image = new Bitmap(Kanvas_Ekstrak.Width, Kanvas_Ekstrak.Height);
        }

        private void Btn_OpenImg_S_Click(object sender, EventArgs e)
        {
            img1 = Draw.GetImg();
            if(img1!=null) Draw.DrawScaledImg(Kanvas_Sisip, img1);
            else MessageBox.Show("Tidak ada gambar yang dipilih", "Informasi");
        }

        private void Btn_SaveImg_Click(object sender, EventArgs e)
        {
            if (img2 != null) Draw.SaveImg(img2);
            else MessageBox.Show("Tidak ada gambar untuk disimpan", "Informasi");
        }

        private void Btn_OpenImg_E_Click(object sender, EventArgs e)
        {
            img3 = Draw.GetImg();
            if (img3 != null) Draw.DrawScaledImg(Kanvas_Ekstrak, img3);
            else MessageBox.Show("Tidak ada gambar yang dipilih", "Informasi");
        }

        private void Btn_Sisip_Click(object sender, EventArgs e)
        {
            if (AES.isASCII(Txt_Sisip.Text)) { Sisip(); }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Pesan mengandung unsur huruf diluar kode AsCII. Apakah anda ingin melakukan normalisasi ?", "Informasi", MessageBoxButtons.YesNo))
                {
                    Txt_Sisip.Text = AES.NormalisasiASCII(Txt_Sisip.Text);
                    Sisip();
                }
                else MessageBox.Show("Maaf tidak dapat menyisipkan pesan yang mengandung huruf diluar karakter ASCII, silahkan cek pesan anda", "Informasi");
            }
        }

        private void Sisip()
        {
            if (img1 != null)
            {
                if (Pilih_Mode.SelectedIndex > -1 && Pilih_Enkrip.SelectedIndex > -1)
                {
                    if (PC.isBmpCukup(Txt_Sisip.Text, Txt_Kunci_S.Text, img1, (Stego.Mode)Pilih_Mode.SelectedIndex, (Stego.Enkrip)Pilih_Enkrip.SelectedIndex))
                    {
                        img2 = PC.Sisip(Txt_Sisip.Text, Txt_Kunci_S.Text, img1, (Stego.Mode)Pilih_Mode.SelectedIndex, (Stego.Enkrip)Pilih_Enkrip.SelectedIndex);
                        Draw.DrawScaledImg(Kanvas_Hsl, img2);
                        MessageBox.Show("Pesan telah disisipkan", "Informasi");
                    }
                    else MessageBox.Show("Gambar tidak cukup menampung pesan, silahkan pilih gambar yang lebih besar", "Informasi");
                }
                else MessageBox.Show("Silahkan cek pilihan Mode atau Enkrip", "Informasi");
            }
            else MessageBox.Show("Silahkan pilih gambar untuk disisipkan pesan", "Informasi");
        }

        private void Btn_Ekstrak_Click(object sender, EventArgs e)
        {
            if (img3 != null)
            {
                if (Pilih_Mode.SelectedIndex > -1 && Pilih_Enkrip.SelectedIndex > -1)
                {
                    if (PC.isKunciSama(img3, Txt_Kunci_E.Text, (Stego.Mode)Pilih_Mode.SelectedIndex, (Stego.Enkrip)Pilih_Enkrip.SelectedIndex))
                    {
                        Txt_Ekstrak.Text = PC.Ekstrak(img3, Txt_Kunci_E.Text, (Stego.Mode)Pilih_Mode.SelectedIndex, (Stego.Enkrip)Pilih_Enkrip.SelectedIndex);
                    }
                    else MessageBox.Show("Kunci tidak sama", "Informasi");
                }
                else MessageBox.Show("Silahkan cek pilihan Mode atau Enkrip", "Informasi");
            }
            else MessageBox.Show("Silahkan pilih gambar untuk diekstrak pesan", "Informasi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            Pilih_Mode.SelectedIndex = -1;
            Pilih_Enkrip.SelectedIndex = -1;
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Sisip.Clear();
            Txt_Kunci_S.Clear();
            Txt_Ekstrak.Clear();
            Txt_Kunci_E.Clear();
            if (img1 != null) img1.Dispose();
            if (img2 != null) img2.Dispose();
            if (img3 != null) img3.Dispose();
            using (Graphics g1 = Graphics.FromImage(Kanvas_Sisip.Image)) { g1.Clear(Color.Transparent); Kanvas_Sisip.Invalidate(); }
            using (Graphics g2 = Graphics.FromImage(Kanvas_Hsl.Image)) { g2.Clear(Color.Transparent); Kanvas_Hsl.Invalidate(); }
            using (Graphics g3 = Graphics.FromImage(Kanvas_Ekstrak.Image)) { g3.Clear(Color.Transparent); Kanvas_Ekstrak.Invalidate(); }
            Pilih_Mode.SelectedIndex = -1; Pilih_Enkrip.SelectedIndex = -1;
            Pilih_Mode.Text = "Pilih Mode"; Pilih_Enkrip.Text = "Pilih Enkrip";
        }

        private void Pilih_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Txt_Sisip.Clear();
            //if (Pilih_Mode.SelectedIndex > -1)
            //{
            //    Txt_Sisip.Text = ("Mode : " + Pilih_Mode.SelectedItem.ToString());
            //}
        }

        private void Pilih_Enkrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Pilih_Enkrip.SelectedIndex > -1)
            //{
            //    Txt_Sisip.Text += ("\nEnkrip : " + Pilih_Enkrip.SelectedItem.ToString());
            //}
        }

        private void Btn_OpenTxt_Click(object sender, EventArgs e)
        {
            Txt_Sisip.Text = Draw.GetText();
        }

        private void Btn_SaveTxt_S_Click(object sender, EventArgs e)
        {
            Draw.SaveText(Txt_Sisip.Text);
        }

        private void Btn_SaveTxt_E_Click(object sender, EventArgs e)
        {
            Draw.SaveText(Txt_Ekstrak.Text);
        }

        private void Txt_Sisip_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Sisip.TextLength > 0) { Lbl_Txt_S.Text = "Panjang Pesan : " + Txt_Sisip.TextLength.ToString(); }
            else Lbl_Txt_S.Text = "Panjang Pesan : ";
        }

        private void Txt_Ekstrak_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Ekstrak.TextLength > 0) { Lbl_Txt_E.Text = "Panjang Pesan : " + Txt_Ekstrak.TextLength.ToString(); }
            else Lbl_Txt_E.Text = "Panjang Pesan : ";
        }

        private void Txt_Kunci_S_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Kunci_S.TextLength > 0) { Lbl_Key_S.Text = "Panjang Kunci : " + Txt_Kunci_S.TextLength.ToString(); }
            else Lbl_Key_S.Text = "Panjang Kunci : ";
        }

        private void Txt_Kunci_E_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Kunci_E.TextLength > 0) { Lbl_Key_E.Text = "Panjang Kunci : " + Txt_Kunci_E.TextLength.ToString(); }
            else Lbl_Key_E.Text = "Panjang Kunci : ";
        }

        private void Histo_S_Click(object sender, EventArgs e)
        {
            if (img1 != null)
            {
                //int[] histo = Draw.GetHistogram(img1);
                shisto_S = new Series();
                //shisto_S_G = new Series();
                //shisto_S_B = new Series();
                shisto_S.ChartType = SeriesChartType.Spline;
                shisto_S.Name = "Original_Image";
                if (!myChart.Series.Contains(shisto_S))
                {
                    myChart.Series.Add(shisto_S);
                }
                
                int[] hist_R = new int[256];
                int[] hist_G = new int[256];
                int[] hist_B = new int[256];
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        hist_R[img1.GetPixel(i, j).R]++;
                        hist_G[img1.GetPixel(i, j).G]++;
                        hist_B[img1.GetPixel(i, j).B]++;
                    }
                }
                myChart.Series["Original_Image"].Points.DataBindY(hist_B);
                myChart.Invalidate();
            }
            else MessageBox.Show("Tidak ada gambar untuk ditampilkan histogram", "Informasi");
        }

        private void Histo_E_Click(object sender, EventArgs e)
        {
            if (img3 != null)
            {
                int[] histo = Draw.GetHistogram(img3);
                //shisto_E = new Series();
                shisto_E.ChartType = SeriesChartType.Spline;
                shisto_E.Name = "Stego_Image";
                if (!myChart.Series.Contains(shisto_E))
                {
                    myChart.Series.Add(shisto_E);
                }
                myChart.Series["Stego_Image"].Points.DataBindY(histo);
                myChart.Invalidate();
            }
            else MessageBox.Show("Tidak ada gambar untuk ditampilkan histogram", "Informasi");
        }
    }
}

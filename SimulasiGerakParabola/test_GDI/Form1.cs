using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FungsiGerakParabola;
using System.IO;

namespace test_GDI
{
    public partial class Form1 : Form
    {
        public string lokasi_data = "_RecordSimulasi.txt";
        public string lokasi_history = "History.txt";
        FileStream fs;
        //string data_baris;
        //int total_baris = 0;
        Graphics kuas;
        Image gambar;
        //Task tsk;
        public int flag = 0;
        public int tanda = 0;
        public double total = 0;
        Timer delay = new Timer();

        public Form1()
        {
            InitializeComponent();
            kanvas.BackgroundImage = new Bitmap("Latar1.bmp");
            kanvas.Image = new Bitmap(kanvas.Width, kanvas.Height);
            kuas = Graphics.FromImage(kanvas.Image);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(0, 0);
            //txt_sudut.Value = 37;
            //txt_v.Value = 100;
            //txt_g.Value = 10;
            txt_skala.Value = 1;
            btn_simpan.Enabled = false;
            btn_reset.Enabled = false;
            cek_history();
        }

        private void cek_history()
        {
            int history = 0;
            if (File.Exists(lokasi_history))
            {
                fs = new FileStream(lokasi_history, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                history = Convert.ToInt32(sr.ReadLine());
                sr.Close(); fs.Close();
            }
            else
            {
                fs = new FileStream(lokasi_history, FileMode.Create); fs.Close();
                fs = new FileStream(lokasi_history, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("0"); sw.Close(); fs.Close();
                history = 0;
            }
            cek_record(history);
        }

        private void cek_record(int urutan)
        {
            string lokasi_data_baru = (urutan + 1).ToString() + lokasi_data;
            if (MessageBox.Show("Ingin Menyimpan Record Simulasi ??", "Pembuatan File Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                fs = new FileStream(lokasi_data_baru, FileMode.Create);
                fs.Close();
                fs = new FileStream(lokasi_history, FileMode.Create); fs.Close();
                fs = new FileStream(lokasi_history, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine((urutan + 1).ToString().Trim()); sw.Close(); fs.Close();
                btn_simpan.Enabled = true;
                lokasi_data = lokasi_data_baru;
                MessageBox.Show("File Record Telah Tersimpan Pada Lokasi :  " + lokasi_data_baru + " !", "Info File Record");
            }
            else
            {
                btn_simpan.Enabled = false;
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            fs = new FileStream(lokasi_data, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string data =
                txt_sudut.Value.ToString().Trim() + "|" +
                txt_v.Value.ToString().Trim() + "|" +
                txt_g.Value.ToString().Trim() + "|" +
                txt_tMax.Text.Trim() + "|" +
                txt_xMax.Text.Trim() + "|" +
                txt_yMax.Text.Trim();
            sw.WriteLine(data);
            sw.Close(); fs.Close();
            MessageBox.Show("Data Telah Tersimpan !", "Info Simpan Data");
            btn_fire.Focus();
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            if (input_benar())
            {
                btn_reset.Enabled = true;
                flag = 0; btn_stop.Text = "Stop";
                double tick = Convert.ToDouble(txt_tick.Value);
                double sudut = Convert.ToDouble(txt_sudut.Value);
                double v = Convert.ToDouble(txt_v.Value);
                double g = Convert.ToDouble(txt_g.Value);
                double skala = Convert.ToDouble(txt_skala.Value);
                double diameter = Convert.ToDouble(txt_diameter.Value);
                Hitung.Koordinat[] xy = new Hitung.Koordinat[0];
                Hitung.Koor(ref xy, sudut, v, g, tick);
                //isi_panel(ref xy, sudut, v, g);
                list_koor.Items.Clear();

                gambar_kanvas(xy, sudut, v, g, tick, skala, diameter);

                Task tsk = new Task(() => { gambar_kanvas(xy, sudut, v, g, tick, skala, diameter); });
                tsk.Start();
                //simpan_image(skala);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            kuas.Clear(Color.Transparent);
            kanvas.Invalidate();
        }

        private bool input_benar()
        {
            if (txt_sudut.Value != 0 && txt_v.Value != 0 && txt_g.Value != 0) return true;
            else return false;
        }

        private void isi_data(Hitung.Koordinat[] xy, int counter, double tMax_tick, double tmp_x, double tmp_y)
        {
            txt_tMax.Text = tMax_tick.ToString("0.00");
            if (xy[counter].x > tmp_x) txt_xMax.Text = xy[counter].x.ToString("0.00");
            if (xy[counter].y > tmp_y) txt_yMax.Text = xy[counter].y.ToString("0.00");
            list_koor.Items.Add(
                " t = " + tMax_tick.ToString("0.00") + "  " +
                " x = " + xy[counter].x.ToString("0.00") + "  " +
                " y = " + xy[counter].y.ToString("0.00"));
            list_koor.SelectedIndex = list_koor.Items.Count - 1;
        }

        private void gambar_kanvas(Hitung.Koordinat[] xy, double sudut, double v, double g, double tick, double skala, double diameter)
        {
            int count = xy.Length, counter = 0;
            double tMax_tick = 0;
            double tmp_x = 0, tmp_y = 0;
            delay = new Timer();
            delay.Interval = Convert.ToInt32(1000 * tick);
            //kanvas.Image = new Bitmap(kanvas.Width, kanvas.Height);
            Random Rnd = new Random();
            Color Warna = Color.FromArgb(Rnd.Next(200), Rnd.Next(200), Rnd.Next(200));
            Pen myPen = new Pen(Warna);
            SolidBrush myBrush = new SolidBrush(Warna);
            delay.Tick += (obj, arg) =>
            {
                //if (flag == 1) { delay.Stop(); flag = 0; }

                if (counter < count)
                {
                    isi_data(xy, counter, tMax_tick, tmp_x, tmp_y);
                    if (chk_jejak.Checked == false) kuas.Clear(Color.Transparent);
                    //gambar_jejak(xy, skala, counter, myBrush);
                    //kuas.DrawLine(myPen,
                    //    Convert.ToInt32(tmp_x / skala),
                    //    kanvas.Height - Convert.ToInt32(tmp_y / skala),
                    //    Convert.ToInt32(xy[counter].x / skala),
                    //    kanvas.Height - Convert.ToInt32(xy[counter].y / skala));
                    tmp_x = xy[counter].x;
                    tmp_y = xy[counter].y;

                    kuas.FillEllipse(myBrush,
                        Convert.ToInt32(xy[counter].x / skala) - Convert.ToInt32(diameter / 2),
                        kanvas.Height - Convert.ToInt32(diameter / 2) - Convert.ToInt32(xy[counter].y / skala),
                        Convert.ToInt32(diameter),
                        Convert.ToInt32(diameter));

                    counter += 1;
                    tMax_tick += tick;
                    //kuas.FillRectangle(Brushes.Red, Convert.ToInt32(xy[counter].x), kanvas.Height - Convert.ToInt32(xy[counter].y), 1, 1);
                    kanvas.Invalidate();
                }
                else delay.Stop();
            };
            delay.Start();
        }

        private void gambar_jejak(Hitung.Koordinat[] xy, double skala, int count, SolidBrush myBrush)
        {
            int tmp_x = 0, tmp_y = 0;
            for (int i = 0; i < count; i++)
            {
                kuas.FillRectangle(myBrush,
                    Convert.ToInt32(xy[i].x / skala),
                    kanvas.Height - Convert.ToInt32(xy[i].y / skala),
                    1,
                    1);
                tmp_x = Convert.ToInt32(xy[i].x);
                tmp_y = Convert.ToInt32(xy[i].y);
            }
        }

        private void simpan_image(double skala)
        {
            //img_temp = new Bitmap(kanvas.Image);
            //Rectangle asal = new Rectangle(0, img_temp.Height - Convert.ToInt32(kanvas.Height * skala), Convert.ToInt32(kanvas.Width * skala), Convert.ToInt32(kanvas.Height * skala));
            //Rectangle tujuan = new Rectangle(0, 0, kanvas.Width, kanvas.Height);
            //Image hasil = new Bitmap(kanvas.Width, kanvas.Height);
            //using (var graphics = Graphics.FromImage(hasil))
            //{
            //    graphics.DrawImage(img_temp, tujuan,
            //        asal, GraphicsUnit.Pixel);
            //}
            //img_temp.Dispose();
            //kanvas.Image = new Bitmap(hasil);
            //hasil.Dispose();
        }

        private void txt_skala_ValueChanged(object sender, EventArgs e)
        {
            ganti_skala(Convert.ToDouble(txt_skala.Value));
        }

        private void ganti_skala(double skala)
        {
            gambar = Image.FromFile("Latar1.bmp");
            Rectangle asal = new Rectangle(0, gambar.Height - Convert.ToInt32(kanvas.Height * skala), Convert.ToInt32(kanvas.Width * skala), Convert.ToInt32(kanvas.Height * skala));
            Rectangle tujuan = new Rectangle(0, 0, kanvas.Width, kanvas.Height);
            Image hasil = new Bitmap(kanvas.Width, kanvas.Height);
            using (var graphics = Graphics.FromImage(hasil))
            {
                graphics.DrawImage(gambar, tujuan,
                    asal, GraphicsUnit.Pixel);
            }
            
            kanvas.BackgroundImage = new Bitmap(hasil);
            hasil.Dispose();
            gambar.Dispose();
            kuas.Clear(Color.Transparent);
            ////Image hasil2 = new Bitmap(hasil);
            ////kanvas.Image = new Bitmap(hasil);
            ////kuas.Clear(Color.Transparent);
            //Rectangle asal3 = new Rectangle(0, 0, kanvas.Width, kanvas.Height);
            //Rectangle tujuan3 = new Rectangle(0, 0, kanvas.Width, kanvas.Height);
            //Image hasil3 = new Bitmap(kanvas.Width, kanvas.Height);
            //kuas.DrawImage(hasil, tujuan3, asal3, GraphicsUnit.Pixel);
            ////using (var graphics = Graphics.FromImage(hasil3))
            ////{
            ////    graphics.DrawImage(kanvas.Image, tujuan,
            ////        asal, GraphicsUnit.Pixel);
            ////}
            ////gambar = new Bitmap(hasil);
            //kanvas.Image = new Bitmap(hasil);
            //kuas = Graphics.FromImage(kanvas.Image);
            
            //Rectangle asal2 = new Rectangle(0, 0, kanvas.Width, kanvas.Height);
            //Rectangle tujuan2 = new Rectangle(0, 0, kanvas.Width, kanvas.Height);
            
            ////kuas.DrawImage(kanvas.Image, tujuan2, asal2, GraphicsUnit.Pixel);
            //Rectangle asal3 = new Rectangle(0, gambar.Height - Convert.ToInt32(kanvas.Height * skala), Convert.ToInt32(kanvas.Width * skala), Convert.ToInt32(kanvas.Height * skala));
            //Rectangle tujuan3 = new Rectangle(0, 0, kanvas.Width, kanvas.Height);
            ////Image hasil2 = new Bitmap(kanvas.Width, kanvas.Height);
            ////Image hasil2 = new Bitmap(gambar.Width, gambar.Height);
            //kuas.DrawImage(kanvas.Image, tujuan3, asal3, GraphicsUnit.Pixel);
            //kanvas.Image = new Bitmap(hasil2);
            //gambar.Dispose();
            //using (var graphics = Graphics.FromImage(hasil2))
            //{
            //    graphics.DrawImage(kanvas.Image, tujuan3,
            //        asal3, GraphicsUnit.Pixel);
            //}
            //kanvas.Image.Dispose();
            //kanvas.Image = new Bitmap(hasil2);
            
            //hasil2.Dispose();
            //kuas.DrawImage(kanvas.Image, tujuan2, asal2, GraphicsUnit.Pixel);
        }

        private void txt_diameter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_hitung_Click(null, null);
            }
        }

        private void btn_fire_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (tanda == 0)
                {
                    total += 1;
                    if (total == 264)
                    {
                        tanda = 1;
                    }
                }
                else if (tanda == 1)
                {
                    total -= 1;
                    if (total == 0)
                    {
                        tanda = 0;
                    }
                }
                btn_fire.Text = total.ToString();
                btn_fire.Refresh();
                txt_v.Value = Convert.ToDecimal(total);
                txt_v.Refresh();
            }

            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.A)
            {
                if (txt_sudut.Value != 90) txt_sudut.Value += 1;
                else txt_sudut.Value = 90;
                txt_sudut.BackColor = Color.Empty;
                txt_sudut.Refresh();
                txt_sudut.BackColor = Color.Green;
            }

            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.S)
            {
                if (txt_sudut.Value != 0) txt_sudut.Value -= 1;
                else txt_sudut.Value = 0;
                txt_sudut.BackColor = Color.Empty;
                txt_sudut.Refresh();
                txt_sudut.BackColor = Color.Red;
            }
        }

        private void btn_fire_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                tanda = 0;
                do { total -= 1; } while (total > 0);
                total = 0; 
                btn_hitung_Click(null, null);
                btn_fire.Text = "Fire";
            }
            if (e.KeyCode == Keys.A||e.KeyCode == Keys.S||e.KeyCode == Keys.W||e.KeyCode == Keys.D)
            {
                txt_sudut.BackColor = Color.Empty;
            }
        }

        private void btn_analisis_Click(object sender, EventArgs e)
        {
            Analys frm_analys = new Analys();
            frm_analys.Show();
        }
    }
    //internal class NumericUpDownControl : NumericUpDown
    //{
    //    #region Constants
    //    protected const String UpKey = "{UP}";
    //    protected const String DownKey = "{DOWN}";
    //    #endregion Constants

    //    #region Base Class Overrides
    //    protected override void OnMouseWheel(MouseEventArgs e_)
    //    {
    //        String key = GetKey(e_.Delta);
    //        SendKeys.Send(key);
    //    }
    //    #endregion Base Class Overrides

    //    #region Protected Methods
    //    protected static String GetKey(int delta_)
    //    {
    //        String key = (delta_ < 0) ? DownKey : UpKey;
    //        return key;
    //    }
    //    #endregion Protected Methods
    //}
}

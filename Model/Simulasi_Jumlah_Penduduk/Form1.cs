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

namespace Simulasi_Jumlah_Penduduk
{
    public partial class Form1 : Form
    {
        double[] laju_indo = { 2.31, 1.98, 1.49, 1.49, 1.40 };
        double[] laju_sumut_v1 = { 2.60, 2.06, 1.32, 1.10, 1.39 };
        double[] laju_sumut_v2 = { 2.06, 1.20, 1.22 };
        double[] laju_medan = { 2.30, 1.00, 0.97 };

        double[] pend_indo = { 119208229, 147490298, 179378946, 194754808, 206264595, 237641326 };
        double[] pend_sumut_v1 = { 6621831, 8360894, 10256027, 11114667, 11649655, 12982204 };
        double[] pend_sumut_v2 = { 8360894, 10256027, 11513973, 12982204 };
        double[] pend_medan = { 1378955, 1730752, 1905587, 2097610 };

        string[] tahun_laju_indo = { "1971-1980", "1980-1990", "1990-2000", "2000-2010", "2010-2014" };
        string[] tahun_laju_sumut_v1 = { "1971-1980", "1980-1990", "1990-2000", "2000-2010", "2010-2014" };
        string[] tahun_laju_sumut_v2 = { "1980-1990", "1990-2000", "2000-2010" };
        string[] tahun_laju_medan = { "1980-1990", "1990-2000", "2000-2010" };

        string[] tahun_pend_indo = { "1971", "1980", "1990", "1995", "2000", "2010" };
        string[] tahun_pend_sumut_v1 = { "1971", "1980", "1990", "1995", "2000", "2010" };
        string[] tahun_pend_sumut_v2 = { "1980", "1990", "2000", "2010" };
        string[] tahun_pend_medan = { "1980", "1990", "2000", "2010" };

        double[] temp_pend = new double[0];
        string[] temp_tahun = new string[0];
        int feed_now = 0;
        int pos = 0;
        double pend = 0;
        int tahun = 0;

        Series series1 = new Series();
        Series series2 = new Series();
        Series series3 = new Series();
        Series series4 = new Series();
        Series series5 = new Series();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cek_awal();
            laju_check.Checked = true;
        }

        private void cek_awal()
        {
            series1.ChartType = SeriesChartType.Spline;
            series1.XValueType = ChartValueType.String;
            series1.IsValueShownAsLabel = true;
            series2.ChartType = SeriesChartType.Spline;
            series2.XValueType = ChartValueType.String;
            series2.IsValueShownAsLabel = true;
            series3.ChartType = SeriesChartType.Spline;
            series3.XValueType = ChartValueType.String;
            series3.IsValueShownAsLabel = true;
            series4.ChartType = SeriesChartType.Spline;
            series4.XValueType = ChartValueType.String;
            series4.IsValueShownAsLabel = true;
            series5.ChartType = SeriesChartType.Spline;
            series5.XValueType = ChartValueType.String;
            series5.IsValueShownAsLabel = true;
        }

        private void cek_hapus()
        {
            if (chart1.Series.Contains(series1)) chart1.Series.Remove(series1);
            if (chart1.Series.Contains(series2)) chart1.Series.Remove(series2);
            if (chart1.Series.Contains(series3)) chart1.Series.Remove(series3);
            if (chart1.Series.Contains(series4)) chart1.Series.Remove(series4);
            if (chart1.Series.Contains(series5)) chart1.Series.Remove(series5);
            chart1.Invalidate();
        }

        private void reset_btn()
        {
            pos = 0;
            if (pos == 0) btn_kurang.Enabled = false;
            btn_indo.BackColor = Color.Transparent;
            btn_sumut_v1.BackColor = Color.Transparent;
            btn_sumut_v2.BackColor = Color.Transparent;
            btn_medan.BackColor = Color.Transparent;
            Array.Resize(ref temp_pend, 0);
            Array.Resize(ref temp_tahun, 0);
            //pos = 0;
        }

        private void tampil_laju(int feed)
        {
            cek_hapus();
            if (feed == 1)
            {
                series1.Name = "laju_indo";
                chart1.Series.Add(series1);
                chart1.Series["laju_indo"].Points.DataBindXY(tahun_laju_indo, laju_indo);
                
            }
            else if (feed == 2)
            {
                series2.Name = "laju_sumut_v1";
                chart1.Series.Add(series2);
                chart1.Series["laju_sumut_v1"].Points.DataBindXY(tahun_laju_sumut_v1, laju_sumut_v1);
            }
            else if (feed == 3)
            {
                series3.Name = "laju_sumut_v2";
                chart1.Series.Add(series3);
                chart1.Series["laju_sumut_v2"].Points.DataBindXY(tahun_laju_sumut_v2, laju_sumut_v2);
            }
            else if (feed == 4)
            {
                series4.Name = "laju_medan";
                chart1.Series.Add(series4);
                chart1.Series["laju_medan"].Points.DataBindXY(tahun_laju_medan, laju_medan);
            }
            //chart1.Series[0].SmartLabelStyle.Enabled = false;
            //chart1.Series[0].LabelAngle = -45;
            chart1.Invalidate();
        }

        private void tampil_pend(int feed)
        {
            cek_hapus();
            if (feed == 1)
            {
                series1.Name = "pend_indo";
                chart1.Series.Add(series1);
                chart1.Series["pend_indo"].Points.DataBindXY(tahun_pend_indo, pend_indo);
                
            }
            else if (feed == 2)
            {
                series2.Name = "pend_sumut_v1";
                chart1.Series.Add(series2);
                chart1.Series["pend_sumut_v1"].Points.DataBindXY(tahun_pend_sumut_v1, pend_sumut_v1);
            }
            else if (feed == 3)
            {
                series3.Name = "pend_sumut_v2";
                chart1.Series.Add(series3);
                chart1.Series["pend_sumut_v2"].Points.DataBindXY(tahun_pend_sumut_v2, pend_sumut_v2);
            }
            else if (feed == 4)
            {
                series4.Name = "pend_medan";
                chart1.Series.Add(series4);
                chart1.Series["pend_medan"].Points.DataBindXY(tahun_pend_medan, pend_medan);
            }
            //chart1.Series[0].SmartLabelStyle.Enabled = false;
            //chart1.Series[0].LabelAngle = -45;
            chart1.Invalidate();
        }

        private void btn_indo_Click(object sender, EventArgs e)
        {
            reset_btn(); btn_indo.BackColor = Color.Lime;
            if (laju_check.Checked) tampil_laju(1);
            else if (pend_check.Checked)
            {
                tampil_pend(1);
                feed_now = 1;
                pend = pend_indo[pend_indo.GetUpperBound(0)];
                tahun = Convert.ToInt32(tahun_pend_indo[tahun_pend_indo.GetUpperBound(0)]);
                Array.Resize(ref temp_pend, temp_pend.Length + pend_indo.Length);
                Array.Copy(pend_indo, temp_pend, pend_indo.Length);
                Array.Resize(ref temp_tahun, temp_tahun.Length + tahun_pend_indo.Length);
                Array.Copy(tahun_pend_indo, temp_tahun, tahun_pend_indo.Length);
            }
        }

        private void btn_sumut_v1_Click(object sender, EventArgs e)
        {
            reset_btn(); btn_sumut_v1.BackColor = Color.Lime;
            if (laju_check.Checked) tampil_laju(2);
            else if (pend_check.Checked)
            {
                tampil_pend(2);
                feed_now = 2;
                pend = pend_sumut_v1[pend_sumut_v1.GetUpperBound(0)];
                tahun = Convert.ToInt32(tahun_pend_sumut_v1[tahun_pend_sumut_v1.GetUpperBound(0)]);
                Array.Resize(ref temp_pend, temp_pend.Length + pend_sumut_v1.Length);
                Array.Copy(pend_sumut_v1, temp_pend, pend_sumut_v1.Length);
                Array.Resize(ref temp_tahun, temp_tahun.Length + tahun_pend_sumut_v1.Length);
                Array.Copy(tahun_pend_sumut_v1, temp_tahun, tahun_pend_sumut_v1.Length);
            }
        }

        private void btn_sumut_v2_Click(object sender, EventArgs e)
        {
            reset_btn(); btn_sumut_v2.BackColor = Color.Lime;
            if (laju_check.Checked) tampil_laju(3);
            else if (pend_check.Checked)
            {
                tampil_pend(3);
                feed_now = 3;
                pend = pend_sumut_v2[pend_sumut_v2.GetUpperBound(0)];
                tahun = Convert.ToInt32(tahun_pend_sumut_v2[tahun_pend_sumut_v2.GetUpperBound(0)]);
                Array.Resize(ref temp_pend, temp_pend.Length + pend_sumut_v2.Length);
                Array.Copy(pend_sumut_v2, temp_pend, pend_sumut_v2.Length);
                Array.Resize(ref temp_tahun, temp_tahun.Length + tahun_pend_sumut_v2.Length);
                Array.Copy(tahun_pend_sumut_v2, temp_tahun, tahun_pend_sumut_v2.Length);
            }
        }

        private void btn_medan_Click(object sender, EventArgs e)
        {
            reset_btn(); btn_medan.BackColor = Color.Lime;
            if (laju_check.Checked) tampil_laju(4);
            else if (pend_check.Checked)
            {
                tampil_pend(4);
                feed_now = 4;
                pend = pend_medan[pend_medan.GetUpperBound(0)];
                tahun = Convert.ToInt32(tahun_pend_medan[tahun_pend_medan.GetUpperBound(0)]);
                Array.Resize(ref temp_pend, temp_pend.Length + pend_medan.Length);
                Array.Copy(pend_medan, temp_pend, pend_medan.Length);
                Array.Resize(ref temp_tahun, temp_tahun.Length + tahun_pend_medan.Length);
                Array.Copy(tahun_pend_medan, temp_tahun, tahun_pend_medan.Length);
            }
        }

        private void laju_check_CheckedChanged(object sender, EventArgs e)
        {
            feed_now = 0; pos = 0;
            if (laju_check.Checked)
            {
                btn_kurang.Enabled = false;
                btn_tambah.Enabled = false;
                btn_indo_Click(null, null);
            }
            else if (pend_check.Checked)
            {
                if (pos >= 0) btn_tambah.Enabled = true;
                if (pos == 0) btn_kurang.Enabled = false;
                btn_indo_Click(null, null); feed_now = 1;
            }
        }

        private void btn_kurang_Click(object sender, EventArgs e)
        {
            tahun -= 5;
            if (pos >= 5) pos -= 5;
            if (pos == 0) btn_kurang.Enabled = false;

            Array.Resize(ref temp_pend, temp_pend.Length -1);
            Array.Resize(ref temp_tahun, temp_tahun.Length - 1);

            cek_hapus();
            series5.Name = "pend_temp";
            chart1.Series.Add(series5);
            chart1.Series["pend_temp"].Points.DataBindXY(temp_tahun, temp_pend);
            chart1.Series[0].SmartLabelStyle.Enabled = false;
            chart1.Series[0].LabelAngle = 90;
            chart1.Invalidate();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            pos += 5; tahun += 5;
            if (pos >= 5) btn_kurang.Enabled = true;

            if (feed_now == 1) pend = Math.Floor(pend + (((laju_indo[laju_indo.GetUpperBound(0)] / 100) * pend)) * 5);
            else if (feed_now == 2) pend = Math.Floor(pend + (((laju_sumut_v1[laju_sumut_v1.GetUpperBound(0)] / 100) * pend)) * 5);
            else if (feed_now == 3) pend = Math.Floor(pend + (((laju_sumut_v2[laju_sumut_v2.GetUpperBound(0)] / 100) * pend)) * 5);
            else if (feed_now == 4) pend = Math.Floor(pend + (((laju_medan[laju_medan.GetUpperBound(0)] / 100) * pend)) * 5);
            
            Array.Resize(ref temp_pend, temp_pend.Length + 1);
            temp_pend[temp_pend.GetUpperBound(0)] = pend;
            Array.Resize(ref temp_tahun, temp_tahun.Length + 1);
            temp_tahun[temp_tahun.GetUpperBound(0)] = tahun.ToString();
            
            cek_hapus();
            series5.Name = "pend_temp";
            chart1.Series.Add(series5);
            chart1.Series["pend_temp"].Points.DataBindXY(temp_tahun, temp_pend);
            chart1.Series[0].SmartLabelStyle.Enabled = false;
            chart1.Series[0].LabelAngle = 90;
            chart1.Invalidate();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            chart1.SaveImage("Gambar Chart.jpg", ChartImageFormat.Jpeg);
            MessageBox.Show("Gambar chart yang sekarang sudah tersimpan");
        }

    }
}

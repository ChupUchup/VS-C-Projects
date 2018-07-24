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

namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //deklarasi objek Series
        Series series1 = new Series();

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            double[] pend_indo = { 119208229, 147490298, 179378946, 194754808, 206264595, 237641326 };
            string[] tahun_pend_indo = { "1971", "1980", "1990", "1995", "2000", "2010" };

            //cek dulu apakah chart1 ada berisi sebuah series atau tidak
            if (chart1.Series.Contains(series1))
            {
                chart1.Invalidate();//kalau ada refresh aja
            }
            else//kalau gak ada baru lakukan operasi menambahkan series ke chart1
            {
                //fungsi utama menampilkan series
                series1.Name = "pend_indo";
                series1.ChartType = SeriesChartType.Spline;
                series1.XValueType = ChartValueType.String;
                chart1.Series.Add(series1);//tambahkan series ke chart1
                chart1.Series["pend_indo"].Points.DataBindXY(tahun_pend_indo, pend_indo);
            }
            chart1.Invalidate(); // buat merefresh perubahan pada chart1
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (chart1.Series.Contains(series1)) chart1.Series.Remove(series1);
            chart1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// Data arrays.
            //string[] seriesArray = { "Cats", "Dogs" ,"test"};
            //int[] pointsArray = { 1, 10, 4 };

            //// Set palette.
            //this.chart1.Palette = ChartColorPalette.SeaGreen;

            //// Set title.
            //this.chart1.Titles.Add("Pets");

            //// Add series.
            //for (int i = 0; i < seriesArray.Length; i++)
            //{
            //    // Add series.
            //    Series series = this.chart1.Series.Add(seriesArray[i]);

            //    // Add point.
            //    series.Points.Add(pointsArray[i]);
            //}
            //this.Size = new Size(1000, 500);
            //this.Location = new Point(0, 0);

            //chart1.Size = new Size(900, 400);
            //chart1.Location = new Point(10, 10);
            ////var xvals = new[] { "januari", "februari", "maret", "april", "mei", "juni", "juli", "agustus", "september" };
            ////var yvals = new[] { 501, 300, 701, 102, 501, 300, -701, 701, 102 };
            ////var yvals2 = new[] { 5001, 4294, 2147483647, 1002, 5001, 3000, -701, 701, 102 };
            //var nama_tahun = new[] { "1971-1980", "1980-1990", "1990-2000", "2000-2010", "2010-2014" };
            //var value_tahun = new[] { 2.31, 1.98, 1.49, 1.49, 1.40 };

            //Array.Resize(ref nama_tahun, nama_tahun.Length + 1);
            //Array.Resize(ref value_tahun, value_tahun.Length + 1);

            //nama_tahun[nama_tahun.GetUpperBound(0)] = "aaa";
            //value_tahun[value_tahun.GetUpperBound(0)] = 5;
            
            
            //var series = new Series();
            //series.Name = "S1";
            //series.ChartType = SeriesChartType.Spline;
            //series.XValueType = ChartValueType.String;

            //var series2 = new Series();
            //series2.Name = "S2";
            //series2.ChartType = SeriesChartType.Spline;
            //series2.XValueType = ChartValueType.String;
            
            //chart1.Series.Add(series);
            ////chart1.Series.Add(series2);
            
            ////chart1.Series["S1"].Points.DataBindXY(xvals, yvals);
            ////chart1.Series["S2"].Points.DataBindXY(xvals, yvals2);
            //chart1.Series["S1"].Points.DataBindXY(nama_tahun, value_tahun);
            
            ////chart1.Invalidate();
            //chart1.SaveImage("aaa.jpg", ChartImageFormat.Jpeg);
        }

        
    }
}

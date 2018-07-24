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
using System.Windows.Forms.DataVisualization.Charting;

namespace test_GDI
{
    public partial class Analys : Form
    {
        FileStream fs;
        struct dataset
        {
            public double sudut;
            public double v;
            public double g;
            public double tMax;
            public double xMax;
            public double yMax;
        }
        public Analys()
        {
            InitializeComponent();
        }

        dataset[] data = new dataset[0];
        double[] xx = new double[0];
        double[] yy = new double[0];

        private void Analys_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(0, 0);
            panel_select.Visible = false;
            panel_select.Enabled = false;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Buka File";
            ofd.CheckPathExists = true;
            ofd.CheckFileExists = true;
            ofd.FileName = "File Text (*.txt)|*.txt";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;
            ofd.FileName = "";
            ofd.InitialDirectory = Application.StartupPath;
            string nama_file="";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!ofd.FileName.Equals(""))
                {
                    nama_file = ofd.FileName;
                    baca_data(nama_file);
                }
            }
            btn_load.Text = nama_file;
            panel_select.Visible = true;
            panel_select.Enabled = true;
        }

        private void baca_data(string nama_file)
        {
            fs = new FileStream(nama_file, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int count=0;
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split('|');
                Array.Resize(ref data, count + 1);
                data[count].sudut = Convert.ToDouble(temp[0]);
                data[count].v = Convert.ToDouble(temp[1]);
                data[count].g = Convert.ToDouble(temp[2]);
                data[count].tMax = Convert.ToDouble(temp[3]);
                data[count].xMax = Convert.ToDouble(temp[4]);
                data[count].yMax = Convert.ToDouble(temp[5]);
                list_data.Items.Add(
                    " sudut = " + data[count].sudut.ToString() + " " +
                    " v = " + data[count].v.ToString() + " " +
                    " g = " + data[count].g.ToString() + " " +
                    " tMax = " + data[count].tMax.ToString() + " " +
                    " xMax = " + data[count].xMax.ToString() + " " +
                    " ymax = " + data[count].yMax.ToString() + " ");
                count += 1;
            }
            ambil_data_x();
            ambil_data_y();
            tampil_graph();
            sr.Close();
            fs.Close();
        }

        private void ambil_data_x()
        {
            int count = data.Length;
            Array.Resize(ref xx, count);
            for (int i = 0; i < count; i++)
            {
                if (rd_x_sudut.Checked) xx[i] = data[i].sudut;
                else if (rd_x_v.Checked) xx[i] = data[i].v;
                else if (rd_x_g.Checked) xx[i] = data[i].g;
                else if (rd_x_tMax.Checked) xx[i] = data[i].tMax;
                else if (rd_x_xMax.Checked) xx[i] = data[i].xMax;
                else if (rd_x_yMax.Checked) xx[i] = data[i].yMax;
            }
        }

        private void ambil_data_y()
        {
            int count = data.Length;
            Array.Resize(ref yy, count);
            for (int i = 0; i < count; i++)
            {
                if (rd_y_sudut.Checked) yy[i] = data[i].sudut;
                else if (rd_y_v.Checked) yy[i] = data[i].v;
                else if (rd_y_g.Checked) yy[i] = data[i].g;
                else if (rd_y_tMax.Checked) yy[i] = data[i].tMax;
                else if (rd_y_xMax.Checked) yy[i] = data[i].xMax;
                else if (rd_y_yMax.Checked) yy[i] = data[i].yMax;
            }
        }
        private void tampil_graph()
        {
            chart1.Series[0].Points.DataBindXY(xx, yy);
        }

        private void rd_x_sudut_Click(object sender, EventArgs e)
        {
            ambil_data_x();
            tampil_graph();
            //Array.Resize(ref yy, 0);
        }

        private void rd_y_sudut_Click(object sender, EventArgs e)
        {
            ambil_data_x();
            tampil_graph();
            //Array.Resize(ref yy, 0);
        }
    }
}

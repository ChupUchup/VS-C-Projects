using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNG
{
    public partial class Form1 : Form
    {
        Random R = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Shown += delegate
            {
                combo_range.Items.Add(1);
                combo_range.Items.Add(10);
                combo_range.Items.Add(100);
                combo_range.Items.Add(1000);
                for (int i = 1; i <= 100; i++) combo_persen.Items.Add(i + " %");
            };

            combo_range.SelectedIndexChanged += delegate { reset(); };
            combo_persen.SelectedIndexChanged += delegate { reset(); };
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            if (combo_range.SelectedIndex > -1 && combo_persen.SelectedIndex > -1)
            {
                hitung();
                cek_sample();
            }
            else 
                MessageBox.Show("Pilih range dan persentasi terlebih dahulu", "Informasi", MessageBoxButtons.OK);
        }

        void hitung()
        {
            double range = (double)Convert.ToInt32(combo_range.Items[combo_range.SelectedIndex]);
            double chance = Convert.ToDouble(combo_persen.SelectedIndex + 1);
            double hsl = 0;
            if (combo_range.SelectedIndex == 0) 
                hsl = R.NextDouble();
            else if (combo_range.SelectedIndex > 0) 
                hsl = (double)R.Next(Convert.ToInt32(range));
            if (hsl <= ((chance / 100) * range)) 
                show_result(1);
            else 
                show_result(0);
        }

        void show_result(int param)
        {
            string message = "";
            if (param == 0) 
                message = "Gagal";
            else if (param == 1) 
                message = "Sukses";
            if (check_normal.Checked)
                list_hsl.Items.Add(message);
            else
                list_hsl.Items.Add("Tumbal => "+message);
            list_hsl.SelectedIndex = list_hsl.Items.Count - 1;
        }

        void cek_sample()
        {
            int sukses = 0, gagal = 0, tumbal = 0, total = list_hsl.Items.Count;
            for (int i = 0; i < total; i++)
            {
                if (list_hsl.Items[i].ToString() == "Sukses")
                    sukses++;
                else if (list_hsl.Items[i].ToString() == "Gagal")
                    gagal++;
                else
                    tumbal++;
            }
            total -= tumbal;
            text_sukses.Text = sukses.ToString();
            text_gagal.Text = gagal.ToString();
            text_total.Text = total.ToString();
            text_prob.Text = ((double)sukses / (double)total).ToString("0.000");
        }

        void reset()
        {
            list_hsl.Items.Clear();
            text_sukses.Text = "";
            text_gagal.Text = "";
            text_total.Text = "";
            text_prob.Text = "";
        }

        private void check_normal_CheckedChanged(object sender, EventArgs e)
        {
            if (check_normal.Checked)
                check_tumbal.Checked = false;
            else if (!check_normal.Checked && !check_tumbal.Checked)
                check_normal.Checked = true;
        }

        private void check_tumbal_CheckedChanged(object sender, EventArgs e)
        {
            if (check_tumbal.Checked)
                check_normal.Checked = false;
            else if (!check_tumbal.Checked && !check_normal.Checked)
                check_tumbal.Checked = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}

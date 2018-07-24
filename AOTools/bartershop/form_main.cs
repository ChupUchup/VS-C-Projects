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

namespace bartershop
{
    public partial class form_main : Form
    {
        public double[] harga_element;
        double[] elemen_value = { 25000, 100000, 200000, 500000, 1000000 };
        double[] item_value = { 200000, 2000000, 12000000, 50000000, 500000, 50000000, 300000, 10000000, 12000000 };
        string[] item_name = { "Book of Craftmanship", "Book of Expertise", "Book of Mastery", "Alchemist Stone", "Mandragora", "Enriched Adamantium", "Blue Saphire", "Depraved Seed", "Phoenix Feather" };
        int index_item = -1;

        public form_main()
        {
            InitializeComponent();
        }

        private void form_main_Shown(object sender, EventArgs e)
        {
            harga_element = get_harga_element();
            combo_item.Items.AddRange(item_name);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            form_element f = new form_element();
            f.Owner = this;
            f.Show();
        }

        private void txt_jumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_jumlah_TextChanged(object sender, EventArgs e)
        {
            kalkulasi();
        }

        private void combo_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            index_item = combo_item.SelectedIndex;
            kalkulasi();
        }

        public void kalkulasi()
        {
            double jumlah = 0;
            TextBox t;
            if (txt_jumlah.TextLength > 0)
            {
                jumlah = Convert.ToDouble(txt_jumlah.Text);
            }
            if (jumlah != 0)
            {
                if (index_item > -1)
                {
                    double value_item = item_value[index_item];
                    double pajak = (value_item * jumlah) / 100;
                    txt_pajak.Text = pajak.ToString("0,0");
                    for (int i = 0; i < 5; i++)
                    {
                        double need_elemen = (value_item * jumlah) / elemen_value[i];
                        t = (TextBox)this.Controls.Find("txt_butuh_" + i, true)[0];
                        t.Text = need_elemen.ToString();
                        t = (TextBox)this.Controls.Find("txt_harga_" + i, true)[0];
                        t.Text = ((need_elemen * harga_element[i]) + pajak).ToString("0,0");
                    }
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    t = (TextBox)this.Controls.Find("txt_butuh_" + i, true)[0];
                    t.Text = "";
                    t = (TextBox)this.Controls.Find("txt_harga_" + i, true)[0];
                    t.Text = "";
                }
                txt_pajak.Text = "";
            }
        }

        public double[] get_harga_element()
        {
            double[] hsl = { 1500, 5000, 10000, 35000, 75000 };
            if (File.Exists("bartershop.chupy"))
            {
                using (var sr = new StreamReader("bartershop.chupy"))
                {
                    string[] tmp = sr.ReadLine().Split(',');
                    for (int i = 0; i < 5; i++)
                    {
                        hsl[i] = Convert.ToDouble(tmp[i]);
                    }
                }
            }
            else
            {
                using (FileStream fs = File.Create("bartershop.chupy"))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.Write("1500,5000,10000,35000,75000");
                    }
                    hsl = get_harga_element();
                }
            }
            return hsl;
        }

        private void form_main_LocationChanged(object sender, EventArgs e)
        {
            if (this.OwnedForms.Count() > 0)
            {
                form_element f = (form_element)this.OwnedForms[0];
                f.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            }
        }
    }
}

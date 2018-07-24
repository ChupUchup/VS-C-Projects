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
    public partial class form_element : Form
    {
        public form_element()
        {
            InitializeComponent();
        }

        private void form_element_Shown(object sender, EventArgs e)
        {
            double[] harga_element = ((form_main)this.Owner).get_harga_element();
            TextBox t;
            for (int i = 0; i < 5; i++)
            {
                t = (TextBox)this.Controls.Find("txt_butuh_" + i, true)[0];
                t.Text = harga_element[i].ToString();
            }
            form_main f = (form_main)this.Owner;
            this.Location = new Point(f.Location.X + f.Size.Width, f.Location.Y);
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            auto_simpan();
            MessageBox.Show("Data telah tersimpan", "Informasi", MessageBoxButtons.OK);
        }

        private void txt_butuh_0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void form_element_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((form_main)this.Owner).btn_edit.Enabled = true;
        }

        void auto_simpan()
        {
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            if (!File.Exists("bartershop.chupy"))
            {
                using (FileStream fs = File.Create("bartershop.chupy"))
                {
                    using (var sw = new StreamWriter(fs))
                    {
                        sw.Write("1500,5000,10000,35000,75000");
                    }
                }
            }
            using (var sw = new StreamWriter("bartershop.chupy"))
            {
                if (txt_butuh_0.TextLength < 1) txt_butuh_0.Text = "0";
                if (txt_butuh_1.TextLength < 1) txt_butuh_1.Text = "0";
                if (txt_butuh_2.TextLength < 1) txt_butuh_2.Text = "0";
                if (txt_butuh_3.TextLength < 1) txt_butuh_3.Text = "0";
                if (txt_butuh_4.TextLength < 1) txt_butuh_4.Text = "0";
                string s =
                    txt_butuh_0.Text + "," +
                    txt_butuh_1.Text + "," +
                    txt_butuh_2.Text + "," +
                    txt_butuh_3.Text + "," +
                    txt_butuh_4.Text;
                sw.Write(s);
            }
            ((form_main)this.Owner).harga_element = ((form_main)this.Owner).get_harga_element();
            ((form_main)this.Owner).kalkulasi();
            progressBar1.Value = 100;
        }

        private void txt_butuh_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                auto_simpan();
            }
        }

        private void form_element_LocationChanged(object sender, EventArgs e)
        {
            form_main f = (form_main)this.Owner;
            f.Location = new Point(this.Location.X - this.Size.Width, this.Location.Y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AOCraft
{
    public partial class InputItem : Form
    {
        #region variables

        SQLiteConnection conn;
        SQLiteDataAdapter da;
        DataSet ds;
        string query = "", current_type = "", current_item = "";

        #endregion variables

        #region method

        public InputItem()
        {
            conn = new SQLiteConnection("Data Source = AOCraft.db");
            ds = new DataSet();
            InitializeComponent();
            InitializeEvent();
        }

        void InitializeEvent()
        {
            this.Shown += delegate
            {
                this.Location = new Point(0, 0);
                load_item_type();
            };

            txt_nama.TextChanged += delegate
            {

            };

            btn_simpan.Click += delegate
            {
                if (btn_simpan.Text == "Simpan")
                {
                    if (combo_type.SelectedIndex > -1)
                    {
                        if (txt_nama.TextLength > 0)
                        {
                            if (txt_harga.TextLength > 0)
                            {
                                string nama = txt_nama.Text,
                                    type = combo_type.Items[combo_type.SelectedIndex].ToString();
                                int harga = Convert.ToInt32(txt_harga.Text);
                                query = @"insert into tbl_item values ('" + nama + "'," + harga + ",'" + type + "')";
                                using (var cmd = new SQLiteCommand(query, conn))
                                {
                                    conn.Open();
                                    MessageBox.Show(cmd.ExecuteNonQuery().ToString() + " Record telah disimpan", "Informasi", MessageBoxButtons.OK);
                                    conn.Close();
                                }
                            }else
                                MessageBox.Show("Silahkan isi harga", "Informasi", MessageBoxButtons.OK);
                        }else
                            MessageBox.Show("Silahkan isi nama", "Informasi", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Silahkan pilih type", "Informasi", MessageBoxButtons.OK);
                }
            };

            list_item.SelectedIndexChanged += delegate
            {

            };

            txt_harga.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        void load_item_type()
        {
            query = @"select * from tbl_type";
            ds.Clear();
            ds = getDs(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                combo_type.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
            }
        }

        DataSet getDs(string q)
        {
            DataSet hsl = new DataSet();
            using (da = new SQLiteDataAdapter(q, conn))
            {
                conn.Open();
                da.Fill(hsl);
                conn.Close();
            }
            return hsl;
        }

        object getData(string q)
        {
            object hsl = null;
            using (var cmd = new SQLiteCommand(q, conn))
            {
                conn.Open();
                hsl = cmd.ExecuteScalar();
                conn.Close();
            }
            return hsl;
        }

        #endregion method
    }
}

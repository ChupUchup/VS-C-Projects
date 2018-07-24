using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aodb
{
    public partial class form_aoitem : Form
    {
        Resources.mySQLITE lite;
        int count_btn = 0, count_nma = 0, count_jlh = 0, count_hrg = 0,
            pos_btn = 0, pos_nma = 1, pos_jlh = 1, pos_hrg = 1, o_height = 0;
        double harga = 0;

        public form_aoitem()
        {
            InitializeComponent();
            lite = new Resources.mySQLITE("Data Source = aodb.db");
            list_search.LostFocus += (s, e) => { list_search.SelectedItems.Clear(); };
            o_height = this.Size.Height;
        }

        private void form_aoitem_Shown(object sender, EventArgs e)
        {
            foreach (DataRow s in lite.get_dataset(@"select type_name from tbl_type").Tables[0].Rows)
            {
                combo_jenis.Items.Add(s.ItemArray[0].ToString());
                combo_jenis_adv.Items.Add(s.ItemArray[0].ToString());
            }
        }

        private void combo_jenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_jenis.SelectedIndex > -1)
            {
                txt_search.Text = "";
                show_item_result(@"select item_name, item_craft_level, item_craftable from tbl_item where item_type='" + combo_jenis.Items[combo_jenis.SelectedIndex] + "' order by item_craft_level asc");
            }
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                combo_jenis.SelectedIndex = -1;
                combo_jenis.Text = "Hasil";
                show_item_result(@"select item_name, item_craft_level, item_craftable from tbl_item where item_name like '%" + txt_search.Text + "%' order by item_craft_level asc");
            }
        }

        private void show_item_result(string query)
        {
            list_search.Items.Clear();
            foreach (DataRow d in lite.get_dataset(query).Tables[0].Rows)
                list_search.Items.Add(
                    new ListViewItem(new string[] { d.ItemArray[0].ToString(),
                        new Func<string, string, string>((x, y) => { return y == "no" ? "" : x; })(d.ItemArray[1].ToString(), d.ItemArray[2].ToString()) }));
        }

        private void Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void list_search_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (list_search.SelectedItems.Count > 0)
                txt_nama_adv.Text = list_search.SelectedItems[0].SubItems[0].Text;
        }

        private void txt_nama_TextChanged(object sender, EventArgs e)
        {
            reset_field();
            if (lite.get_datacell(@"select item_name from tbl_item where item_name='" + txt_nama_adv.Text + "'") != null)
            {
                DataTable T = lite.get_dataset(@"select * from tbl_item where item_name='" + txt_nama_adv.Text + "'").Tables[0];
                combo_jenis_adv.SelectedIndex = combo_jenis_adv.Items.IndexOf(T.Rows[0].ItemArray[1]);
                txt_level.Text = T.Rows[0].ItemArray[3].ToString();
                txt_c_level.Text = T.Rows[0].ItemArray[4].ToString();
                txt_c_exp.Text = T.Rows[0].ItemArray[5].ToString();
                txt_c_batch.Text = T.Rows[0].ItemArray[6].ToString();
                txt_harga_adv.Text = T.Rows[0].ItemArray[7].ToString();
                txt_tree.Text = T.Rows[0].ItemArray[8].ToString();
                combo_c_able.SelectedIndex = combo_c_able.Items.IndexOf(T.Rows[0].ItemArray[2]);
                btn_simpan.Text = "Update";
            }
            else
                btn_simpan.Text = "Simpan";
        }

        private void reset_field()
        {
            combo_jenis_adv.SelectedIndex = -1;
            combo_c_able.SelectedIndex = -1;
            txt_level.Text = "";
            txt_c_level.Text = "";
            txt_c_exp.Text = "";
            txt_c_batch.Text = "";
            txt_harga_adv.Text = "";
            txt_tree.Text = "";
            txt_harga_adv.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (condition_meet())
            {
                string query = "";
                string
                    item_name = txt_nama_adv.Text,
                    item_type = combo_jenis_adv.Items[combo_jenis_adv.SelectedIndex].ToString(),
                    item_craftable = combo_c_able.Items[combo_c_able.SelectedIndex].ToString();
                int
                    item_level = Convert.ToInt32(txt_level.Text),
                    item_craft_level = Convert.ToInt32(txt_c_level.Text),
                    item_craft_exp = Convert.ToInt32(txt_c_exp.Text),
                    item_craft_batch = Convert.ToInt32(txt_c_batch.Text),
                    item_price = Convert.ToInt32(txt_harga_adv.Text),
                    item_tree = Convert.ToInt32(txt_tree.Text);
                if (btn_simpan.Text == "Simpan")
                {
                    query = @"insert into tbl_item values('" + item_name + "','" + item_type + "','" + item_craftable + "'," + item_level + "," + item_craft_level + "," + item_craft_exp + "," + item_craft_batch + "," + item_price + "," + item_tree + ")";
                    MessageBox.Show(lite.insert_data(query) + " data telah tersimpan", "Informasi", MessageBoxButtons.OK);
                }
                else if (btn_simpan.Text == "Update")
                {
                    query = @"update tbl_item set item_name='" + item_name + "', item_type='" + item_type + "', item_craftable='" + item_craftable + "', item_level=" + item_level + ", item_craft_level=" + item_craft_level + ", item_craft_exp=" + item_craft_exp + ", item_craft_batch=" + item_craft_batch + ", item_price=" + item_price + ", item_tree_level=" + item_tree + " where item_name='" + item_name + "'";
                    MessageBox.Show(lite.insert_data(query) + " data telah terupdate", "Informasi", MessageBoxButtons.OK);
                }
                if(item_craftable=="yes")
                    simpan_craft();
                txt_nama_adv.Text = "";
                txt_nama_adv.Text = item_name;
            }
            else
                MessageBox.Show("Silahkan isi data yang diperlukan", "Informasi", MessageBoxButtons.OK);
        }

        private bool condition_meet()
        {
            bool hsl = false;
            if (txt_nama_adv.Text == "") hsl = false;
            else
            {
                if (combo_jenis_adv.SelectedIndex < 0) hsl = false;
                else
                {
                    if (combo_c_able.SelectedIndex < 0) hsl = false;
                    else
                    {
                        if (txt_level.Text == "") hsl = false;
                        else
                        {
                            if (txt_c_level.Text == "") hsl = false;
                            else
                            {
                                if (txt_c_exp.Text == "") hsl = false;
                                else
                                {
                                    if (txt_c_batch.Text == "") hsl = false;
                                    else
                                    {
                                        if (txt_harga_adv.Text == "") hsl = false;
                                        else
                                        {
                                            if (txt_tree.Text == "") hsl = false;
                                            else
                                                hsl = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return hsl;
        }

        private void simpan_craft()
        {
            int count = 0, harga_ = 0;
            string q = "";
            foreach (Control c in panel_craft.Controls)
            {
                if (c.GetType() == typeof(Button))
                    count += 1;
            }
            count -= 1;
            string[] list_item = new string[count];
            for (int i = 0; i < count; i++)
            {
                string s =
                    ((TextBox)panel_craft.Controls.Find("txt_nma_" + i.ToString(), true)[0]).Text + "(" +
                    ((TextBox)panel_craft.Controls.Find("txt_jlh_" + i.ToString(), true)[0]).Text + ")";
                list_item[i] = s;
                q = @"update tbl_item set item_price=" +
                    Convert.ToInt32(((TextBox)panel_craft.Controls.Find("txt_hrg_" + i.ToString(), true)[0]).Text) +
                    " where item_name='" +
                    ((TextBox)panel_craft.Controls.Find("txt_nma_" + i.ToString(), true)[0]).Text + "'";
                lite.insert_data(q);
                harga_ += (
                    Convert.ToInt32(((TextBox)panel_craft.Controls.Find("txt_jlh_" + i.ToString(), true)[0]).Text) *
                    Convert.ToInt32(((TextBox)panel_craft.Controls.Find("txt_hrg_" + i.ToString(), true)[0]).Text));
            }
            string recipe = string.Join(",", list_item);
            if (lite.get_datacell(@"select craft_recipe from tbl_craft where craft_name='" + txt_nama_adv.Text + "'") == null)
                q = @"insert into tbl_craft values('" + txt_nama_adv.Text + "','" + recipe + "')";
            else
                q = @"update tbl_craft set craft_recipe='" + recipe + "' where craft_name='" + txt_nama_adv.Text + "'";
            lite.insert_data(q);
            harga_ /= Convert.ToInt32(txt_c_batch.Text);
            q = @"update tbl_item set item_price=" + harga_ + " where item_name='" + txt_nama_adv.Text + "'";
            lite.insert_data(q);
        }

        private void combo_c_able_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset_craft();
            if (combo_c_able.SelectedIndex == 0)
            {
                btn_add();
                if (lite.get_datacell(@"select craft_name from tbl_craft where craft_name='" + txt_nama_adv.Text + "'") != null)
                {
                    btn_simpan.Text = "Update";
                    string[] list_item = ((string)lite.get_datacell(@"select craft_recipe from tbl_craft where craft_name='" + txt_nama_adv.Text + "'")).Split(',');
                    if (list_item[0] != "")
                    {
                        for (int i = 0; i < list_item.Count(); i++)
                        {
                            var btn_aad = (Button)panel_craft.Controls.Find("btn_add_" + i.ToString(), true)[0];
                            add_btn_Click(btn_aad, null);
                            var txt_nma = (TextBox)panel_craft.Controls.Find("txt_nma_" + i.ToString(), true)[0];
                            var txt_jlh = (TextBox)panel_craft.Controls.Find("txt_jlh_" + i.ToString(), true)[0];
                            var txt_hrg = (TextBox)panel_craft.Controls.Find("txt_hrg_" + i.ToString(), true)[0];
                            txt_nma.ForeColor = Color.Black;
                            txt_jlh.ForeColor = Color.Black;
                            txt_hrg.ForeColor = Color.Black;
                            txt_nma.Text = (string)list_item[i].Split('(')[0];
                            txt_jlh.Text = (string)list_item[i].Split('(')[1].Trim(')');
                            txt_hrg.Text = Convert.ToInt32(lite.get_datacell(@"select item_price from tbl_item where item_name='" + txt_nma.Text + "'")).ToString();
                            harga += (Convert.ToDouble(txt_jlh.Text) * Convert.ToDouble(txt_hrg.Text));
                        }
                        harga /= Convert.ToDouble(txt_c_batch.Text);
                        if (txt_harga_adv.Text != ((int)harga).ToString())
                            txt_harga_adv.BackColor = Color.PaleVioletRed;
                        else
                            txt_harga_adv.BackColor = Color.FromArgb(192, 255, 192);
                    }
                }
            }
        }

        private void reset_craft()
        {
            panel_craft.Controls.Clear();
            count_btn = 0;
            count_nma = 0;
            count_jlh = 0;
            count_hrg = 0;
            pos_btn = 0;
            pos_nma = 1;
            pos_jlh = 1;
            pos_hrg = 1;
            harga = 0;
            this.Size = new Size(this.Width, o_height);
        }

        private void btn_add()
        {
            Button add_btn = new Button();
            add_btn.BackColor = Color.FromKnownColor(KnownColor.Control);
            add_btn.Name = "btn_add_" + count_btn.ToString();
            add_btn.Size = new Size(22, 22);
            add_btn.Text = "+";
            add_btn.Location = new Point(5, pos_btn);
            add_btn.Click += add_btn_Click;
            panel_craft.Controls.Add(add_btn);
            count_btn += 1;
            pos_btn += 22;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Button btn_aad = (Button)sender;
            TextBox txt_nma = new TextBox();
            TextBox txt_jlh = new TextBox();
            TextBox txt_hrg = new TextBox();

            if (btn_aad.Text == "+")
            {
                this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 22);
                txt_nama();
                txt_jumlah();
                txt_harga();
                btn_add();
                btn_aad.Text = "-";
            }
            else
            {
                int x = Convert.ToInt32(btn_aad.Name.Substring(8));
                txt_nma = (TextBox)panel_craft.Controls["txt_nma_" + x.ToString()];
                txt_jlh = (TextBox)panel_craft.Controls["txt_jlh_" + x.ToString()];
                txt_hrg = (TextBox)panel_craft.Controls["txt_hrg_" + x.ToString()];
                List<Button> list_btn = new List<Button>();
                List<TextBox> list_nma = new List<TextBox>();
                List<TextBox> list_jlh = new List<TextBox>();
                List<TextBox> list_hrg = new List<TextBox>();

                foreach (Control c in panel_craft.Controls)
                {
                    if (c.GetType() == typeof(Button))
                    {
                        if (Convert.ToInt32(((Button)c).Name.Substring(8)) > x)
                            list_btn.Add((Button)c);
                    }
                    else if (c.GetType() == typeof(TextBox))
                    {
                        string z = ((TextBox)c).Name.Substring(4, 3);
                        if (Convert.ToInt32(((TextBox)c).Name.Substring(8)) > x - 1)
                        {
                            if ((z == "nma"))
                                list_nma.Add((TextBox)c);
                            else if (z == "jlh")
                                list_jlh.Add((TextBox)c);
                            else if (z == "hrg")
                                list_hrg.Add((TextBox)c);
                        }
                    }
                }
                if (list_btn.Count > 0)
                {
                    foreach (Button b in list_btn)
                    {
                        int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                        b.Location = new Point(b.Location.X, b.Location.Y - 22);
                        string q = b.Name.Remove(8);
                        q = q.Insert(8, y.ToString());
                        b.Name = q;
                    }
                }
                if (list_nma.Count > 0)
                {
                    foreach (TextBox b in list_nma)
                    {
                        int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                        b.Location = new Point(b.Location.X, b.Location.Y - 22);
                        string q = b.Name.Remove(8);
                        q = q.Insert(8, y.ToString());
                        b.Name = q;
                    }
                }
                if (list_jlh.Count > 0)
                {
                    foreach (TextBox b in list_jlh)
                    {
                        int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                        b.Location = new Point(b.Location.X, b.Location.Y - 22);
                        string q = b.Name.Remove(8);
                        q = q.Insert(8, y.ToString());
                        b.Name = q;
                    }
                }
                if (list_hrg.Count > 0)
                {
                    foreach (TextBox b in list_hrg)
                    {
                        int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                        b.Location = new Point(b.Location.X, b.Location.Y - 22);
                        string q = b.Name.Remove(8);
                        q = q.Insert(8, y.ToString());
                        b.Name = q;
                    }
                }
                count_btn -= 1;
                count_nma -= 1;
                count_jlh -= 1;
                count_hrg -= 1;
                pos_btn -= 22;
                pos_nma -= 22;
                pos_jlh -= 22;
                pos_hrg -= 22;
                ((Button)sender).Focus();
                btn_aad.Dispose();
                txt_nma.Dispose();
                txt_jlh.Dispose();
                txt_hrg.Dispose();
                this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 22);
            }
        }

        private void txt_nama()
        {
            //textbox
            TextBox t = new TextBox();
            t.Name = "txt_nma_" + count_nma.ToString();
            t.Size = new Size(115, 20);
            t.Location = new Point(23 + 5, pos_nma);
            //listbox
            ListBox l = new ListBox();
            l.Hide();
            l.SelectedIndexChanged += (s, e) =>
            {
                t.Text = ((ListBox)s).Items[((ListBox)s).SelectedIndex].ToString();
                t.SelectionStart = t.TextLength;
                l.Hide();
            };
            //textbox
            t.ForeColor = Color.Gray;
            t.Text = "Pilih Item";
            t.GotFocus += (s, e) => {
                if (((TextBox)s).Text == "Pilih Item")
                {
                    ((TextBox)s).Text = "";
                    ((TextBox)s).ForeColor = Color.Black;
                }
            };
            t.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(((TextBox)s).Text))
                {
                    ((TextBox)s).ForeColor = Color.Gray;
                    ((TextBox)s).Text = "Pilih Item";
                }
            };
            t.DoubleClick += (s, e) => { txt_nama_adv.Text = t.Text; };
            t.TextChanged += (s, e) =>
            {
                var target = (TextBox)s;
                l.Size = new System.Drawing.Size(225, target.Height * 5);
                l.Location = new Point(target.Location.X, target.Location.Y + target.Height);
                if (target.Focused)
                {
                    if (string.IsNullOrWhiteSpace(target.Text))
                        l.Hide();
                    else
                    {
                        l.Items.Clear();
                        foreach (DataRow d in lite.get_dataset(@"select item_name from tbl_item where item_name like '%" + t.Text + "%' order by item_craft_level asc").Tables[0].Rows)
                            l.Items.Add(d.ItemArray[0].ToString());
                        l.Show();
                    }
                }
                else
                    l.Hide();
            };
            t.Disposed += (s, e) => { l.Dispose(); };
            panel_craft.Controls.Add(t);
            panel_craft.Controls.Add(l);
            count_nma += 1;
            pos_nma += 22;
        }

        private void txt_jumlah()
        {
            TextBox txt_jlh = new TextBox();
            txt_jlh.Name = "txt_jlh_" + count_jlh.ToString();
            txt_jlh.Size = new Size(31, 20);
            txt_jlh.Location = new Point(23 + 116 + 5 + 1, pos_jlh);
            txt_jlh.KeyPress += Edit_KeyPress;
            txt_jlh.ForeColor = Color.Gray;
            txt_jlh.Text = "Qty";
            txt_jlh.GotFocus += (s, e) =>
            {
                if (((TextBox)s).Text == "Qty")
                {
                    ((TextBox)s).Text = "";
                    ((TextBox)s).ForeColor = Color.Black;
                }
            };
            txt_jlh.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(((TextBox)s).Text))
                {
                    ((TextBox)s).ForeColor = Color.Gray;
                    ((TextBox)s).Text = "Qty";
                }
            };
            panel_craft.Controls.Add(txt_jlh);
            count_jlh += 1;
            pos_jlh += 22;
        }

        private void txt_harga()
        {
            TextBox txt_hrg = new TextBox();
            txt_hrg.Name = "txt_hrg_" + count_hrg.ToString();
            txt_hrg.Size = new Size(75, 20);
            txt_hrg.Location = new Point(23 + 116 + 32 + 5 + 2, pos_hrg);
            txt_hrg.KeyPress += Edit_KeyPress;
            txt_hrg.ForeColor = Color.Gray;
            txt_hrg.Text = "Harga";
            txt_hrg.GotFocus += (s, e) =>
            {
                if (((TextBox)s).Text == "Harga")
                {
                    ((TextBox)s).Text = "";
                    ((TextBox)s).ForeColor = Color.Black;
                }
            };
            txt_hrg.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(((TextBox)s).Text))
                {
                    ((TextBox)s).ForeColor = Color.Gray;
                    ((TextBox)s).Text = "Harga";
                }
            };
            panel_craft.Controls.Add(txt_hrg);
            count_hrg += 1;
            pos_hrg += 22;
        }

    }
}

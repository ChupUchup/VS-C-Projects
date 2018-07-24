using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SergeUtils;

namespace aodb
{
    public partial class form_craft : Form
    {
        public class MethodItem
        {
            public string Name { get; set; }
            public StringMatchingMethod Value { get; set; }
        }

        #region variables

        Resources.mySQLITE lite;
        int count_btn = 0, count_nma = 0, count_jlh = 0, count_hrg = 0,
            pos_btn = 0, pos_nma = 1, pos_jlh = 1, pos_hrg = 1, harga = 0;
        string[] item_name;
        string q = "";

        #endregion variables

        #region method

        public form_craft()
        {
            InitializeComponent();
            lite = new Resources.mySQLITE("Data Source = aodb.db");
        }

        private void form_craft_Shown(object sender, EventArgs e)
        {
            form_item f = (form_item)this.Owner;
            this.Location = new Point(f.Location.X + f.Size.Width, f.Location.Y);
            DataSet ds = lite.get_dataset(@"select item_name from tbl_item");
            item_name = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                item_name[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            //btn_add();
        }

        void btn_add()
        {
            Button add_btn = new Button();
            add_btn.Name = "btn_add_" + count_btn.ToString();
            add_btn.Size = new Size(23, 23);
            add_btn.Text = "+";
            add_btn.Location = new Point(0, pos_btn);
            add_btn.Click += add_btn_Click;
            panel_item.Controls.Add(add_btn);
            count_btn += 1;
            pos_btn += 23;
        }

        void add_btn_Click(object sender, EventArgs e)
        {
            Button btn_aad = (Button)sender;
            EasyCompletionComboBox cmb_nma = new EasyCompletionComboBox();
            TextBox txt_jlh = new TextBox();
            TextBox txt_hrg = new TextBox();
            
            if (btn_aad.Text == "+")
            {
                cmb_nama();
                txt_jumlah();
                txt_harga();
                btn_add();
                btn_aad.Text = "-";
            }
            else
            {
                int x = Convert.ToInt32(btn_aad.Name.Substring(8));
                cmb_nma = (EasyCompletionComboBox)panel_item.Controls["cmb_nma_" + x.ToString()];
                txt_jlh = (TextBox)panel_item.Controls["txt_jlh_" + x.ToString()];
                txt_hrg = (TextBox)panel_item.Controls["txt_hrg_" + x.ToString()];
                List<Button> list_btn = new List<Button>();
                List<EasyCompletionComboBox> list_nma = new List<EasyCompletionComboBox>();
                List<TextBox> list_jlh = new List<TextBox>();
                List<TextBox> list_hrg = new List<TextBox>();
                
                foreach (Control c in panel_item.Controls)
                {
                    if (c.GetType() == typeof(Button))
                    {
                        if (Convert.ToInt32(((Button)c).Name.Substring(8)) > x)
                        {
                            list_btn.Add((Button)c);
                        }
                    }
                    else if (c.GetType() == typeof(EasyCompletionComboBox))
                    {
                        if (Convert.ToInt32(((EasyCompletionComboBox)c).Name.Substring(8)) > x - 1)
                        {
                            list_nma.Add((EasyCompletionComboBox)c);
                        }
                    }
                    else if (c.GetType() == typeof(TextBox))
                    {
                        string z = ((TextBox)c).Name.Substring(4, 3);
                        if (Convert.ToInt32(((TextBox)c).Name.Substring(8)) > x - 1)
                        {
                            if (z == "jlh")
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
                        b.Location = new Point(b.Location.X, b.Location.Y - 23);
                        string q = b.Name.Remove(8);
                        q = q.Insert(8, y.ToString());
                        b.Name = q;
                    }
                }
                if (list_nma.Count > 0)
                {
                    foreach (EasyCompletionComboBox b in list_nma)
                    {
                        int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                        b.Location = new Point(b.Location.X, b.Location.Y - 23);
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
                        b.Location = new Point(b.Location.X, b.Location.Y - 23);
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
                        b.Location = new Point(b.Location.X, b.Location.Y - 23);
                        string q = b.Name.Remove(8);
                        q = q.Insert(8, y.ToString());
                        b.Name = q;
                    }
                }
                count_btn -= 1;
                count_nma -= 1;
                count_jlh -= 1;
                count_hrg -= 1;
                pos_btn -= 23;
                pos_nma -= 23;
                pos_jlh -= 23;
                pos_hrg -= 23;
                btn_aad.Dispose();
                cmb_nma.Dispose();
                txt_jlh.Dispose();
                txt_hrg.Dispose();
            }
        }

        void cmb_nama()
        {
            EasyCompletionComboBox cmb_nma = new EasyCompletionComboBox();
            cmb_nma.Name = "cmb_nma_" + count_nma.ToString();
            cmb_nma.Size = new Size(200, 21);
            cmb_nma.Location = new Point(23, pos_nma);
            cmb_nma.MatchingMethod = StringMatchingMethod.UseWildcards;
            cmb_nma.Items.AddRange(item_name);
            cmb_nma.SelectedIndexChanged += cmb_nma_SelectedIndexChanged;
            panel_item.Controls.Add(cmb_nma);
            count_nma += 1;
            pos_nma += 23;
        }

        void cmb_nma_SelectedIndexChanged(object sender, EventArgs e)
        {
            var target = (EasyCompletionComboBox)sender;
            int x = Convert.ToInt32(target.Name.Substring(8));
            int harga = 0;
            string q = @"select item_price from tbl_item where item_name='" + target.Items[target.SelectedIndex].ToString() + "'";
            var jlh = (TextBox)panel_item.Controls.Find("txt_jlh_" + x.ToString(), true)[0];
            //jlh.Text = jumlah.ToString();
            harga = Convert.ToInt32(lite.get_datacell(q));
            var hrg = (TextBox)panel_item.Controls.Find("txt_hrg_" + x.ToString(), true)[0];
            hrg.Text = harga.ToString();
            
        }

        void txt_jumlah()
        {
            TextBox txt_jlh = new TextBox();
            txt_jlh.Name = "txt_jlh_" + count_jlh.ToString();
            txt_jlh.Size = new Size(50, 20);
            txt_jlh.Location = new Point(23 + 200 + 1, pos_jlh);
            txt_jlh.Text = "1";
            txt_jlh.KeyPress += txt_jlh_KeyPress;
            txt_jlh.KeyDown += txt_jlh_KeyDown;
            panel_item.Controls.Add(txt_jlh);
            count_jlh += 1;
            pos_jlh += 23;
        }

        void txt_jlh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save_Click(null, null);
            }
        }

        void txt_jlh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void txt_harga()
        {
            TextBox txt_hrg = new TextBox();
            txt_hrg.Name = "txt_hrg_" + count_hrg.ToString();
            txt_hrg.Size = new Size(108, 20);
            txt_hrg.Location = new Point(23 + 200 + 50 + 2, pos_hrg);
            txt_hrg.KeyPress += txt_jlh_KeyPress;
            txt_hrg.KeyDown += txt_jlh_KeyDown;
            panel_item.Controls.Add(txt_hrg);
            count_hrg += 1;
            pos_hrg += 23;
        }

        public void check_craft()
        {
            panel_item.Controls.Clear();
            reset_variables();
            if (!item_existed(txt_item_name.Text))
            {
                btn_add();
                btn_save.Text = "Save";
            }
            else
            {
                btn_add();
                btn_save.Text = "Update";
                q = @"select craft_recipe from tbl_craft where craft_name='" + txt_item_name.Text + "'";
                string[] list_item = ((string)lite.get_datacell(q)).Split(',');
                if (list_item[0] != "")
                {
                    for (int i = 0; i < list_item.Count(); i++)
                    {
                        var btn_aad = (Button)panel_item.Controls.Find("btn_add_" + i.ToString(), true)[0];
                        add_btn_Click(btn_aad, null);
                        var cmb_nma = (EasyCompletionComboBox)panel_item.Controls.Find("cmb_nma_" + i.ToString(), true)[0];
                        var txt_jlh = (TextBox)panel_item.Controls.Find("txt_jlh_" + i.ToString(), true)[0];
                        //var txt_hrg = (TextBox)panel_item.Controls.Find("txt_hrg_" + i.ToString(), true)[0];
                        cmb_nma.SelectedIndex = item_name.ToList().IndexOf(list_item[i].Split('(')[0]);
                        txt_jlh.Text = (string)list_item[i].Split('(')[1].Trim(')');
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int count = 0; harga = 0;
            string message = "";
            foreach (Control c in panel_item.Controls)
            {
                if (c.GetType() == typeof(EasyCompletionComboBox))
                    count += 1;
            }
            string[] list_item = new string[count];
            for (int i = 0; i < count; i++)
            {
                string s =
                    ((EasyCompletionComboBox)panel_item.Controls.Find("cmb_nma_" + i.ToString(), true)[0]).Text + "(" +
                    ((TextBox)panel_item.Controls.Find("txt_jlh_" + i.ToString(), true)[0]).Text + ")";
                list_item[i] = s;
                q = @"update tbl_item set item_price=" +
                    Convert.ToInt32(((TextBox)panel_item.Controls.Find("txt_hrg_" + i.ToString(), true)[0]).Text) +
                    " where item_name='" +
                    ((EasyCompletionComboBox)panel_item.Controls.Find("cmb_nma_" + i.ToString(), true)[0]).Text + "'";
                lite.insert_data(q);
                harga += (
                    Convert.ToInt32(((TextBox)panel_item.Controls.Find("txt_jlh_" + i.ToString(), true)[0]).Text) *
                    Convert.ToInt32(((TextBox)panel_item.Controls.Find("txt_hrg_" + i.ToString(), true)[0]).Text));
            }
            string recipe = string.Join(",", list_item);
            if (btn_save.Text == "Save")
            {
                q = @"insert into tbl_craft values('" + txt_item_name.Text + "','" + recipe + "')";
                message = "tersimpan";
                //MessageBox.Show(lite.insert_data(q).ToString() + " Data telah tersimpan", "Informasi", MessageBoxButtons.OK);
            }
            else if (btn_save.Text == "Update")
            {
                q = @"update tbl_craft set craft_recipe='" + recipe + "' where craft_name='" + txt_item_name.Text + "'";
                message = "terupdate";
                //MessageBox.Show(lite.insert_data(q).ToString() + " Data telah terupdate", "Informasi", MessageBoxButtons.OK);
            }
            int hsl = lite.insert_data(q);
            if (sender != null)
            {
                MessageBox.Show(hsl.ToString() + " Data telah " + message, "Informasi", MessageBoxButtons.OK);
            }
            q = @"select item_craft_batch from tbl_item where item_name='" + txt_item_name.Text + "'";
            int batch = Convert.ToInt32(lite.get_datacell(q));
            harga = harga / batch;
            q = @"update tbl_item set item_price=" + harga + " where item_name='" + txt_item_name.Text + "'";
            lite.insert_data(q);
            ((form_item)this.Owner).item_check();
            //check_craft();
        }

        bool item_existed(string item_name_)
        {
            bool hsl = false;
            q = @"select craft_name from tbl_craft where craft_name='" + item_name_ + "'";
            if ((string)lite.get_datacell(q) == null)
                hsl = false;
            else
                hsl = true;
            return hsl;
        }

        void reset_variables()
        {
            count_btn = 0; count_nma = 0; count_jlh = 0; count_hrg = 0;
            pos_btn = 0; pos_nma = 1; pos_jlh = 1; pos_hrg = 1;
        }

        private void form_craft_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((form_item)this.Owner).btn_craft.Enabled = true;
        }

        private void form_craft_LocationChanged(object sender, EventArgs e)
        {
            form_item f = (form_item)this.Owner;
            f.Location = new Point(this.Location.X - f.Size.Width, this.Location.Y);
        }

        #endregion method

    }
}

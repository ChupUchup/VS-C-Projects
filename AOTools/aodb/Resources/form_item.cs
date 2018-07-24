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
    public partial class form_item : Form
    {
        public class MethodItem
        {
            public string Name { get; set; }
            public StringMatchingMethod Value { get; set; }
        }

        Resources.mySQLITE lite;
        string[] item_name, type_name;

        public form_item()
        {
            InitializeComponent();
            lite = new Resources.mySQLITE("Data Source = aodb.db");
            cmb_type.DropDownHeight = 197;
            cmb_type.MatchingMethod = StringMatchingMethod.UseWildcards;
            cmb_name.DropDownHeight = 197;
            cmb_name.MatchingMethod = StringMatchingMethod.UseWildcards;
        }

        private void form_item_Shown(object sender, EventArgs e)
        {
            DataSet ds = lite.get_dataset(@"select item_name from tbl_item");
            item_name = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                item_name[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            ds = lite.get_dataset(@"select type_name from tbl_type");
            type_name = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                type_name[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            cmb_name.Items.AddRange(item_name);
            cmb_type.Items.AddRange(type_name);
        }

        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmb_name_TextChanged(object sender, EventArgs e)
        {
            item_check();
        }

        public void item_check()
        {
            string q = @"select item_name from tbl_item where item_name='" + cmb_name.Text + "'";
            object name = lite.get_datacell(q);
            if (name != null)
            {
                DataSet ds = lite.get_dataset(@"select * from tbl_item where item_name='" + cmb_name.Text + "'");
                int index = cmb_type.Items.IndexOf(ds.Tables[0].Rows[0].ItemArray[1]);
                if (index != cmb_type.SelectedIndex)
                    cmb_type.SelectedIndex = index;
                index = cmb_craftable.Items.IndexOf(ds.Tables[0].Rows[0].ItemArray[2]);
                cmb_craftable.SelectedIndex = index;
                if (ds.Tables[0].Rows[0].ItemArray[2].ToString() == "yes")
                    btn_craft.Enabled = true;
                else
                    btn_craft.Enabled = false;
                txt_level.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                txt_craft_level.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                txt_craft_exp.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                txt_craft_batch.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                txt_price.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                progressBar1.Value = 0;
                btn_save.Text = "Update";
            }
            else
                form_reset();
        }

        void form_reset()
        {
            cmb_type.SelectedIndex = -1;
            cmb_type.Text = "pilih type";
            cmb_craftable.SelectedIndex = -1;
            cmb_craftable.Text = "yes / no";
            txt_level.Text = "";
            txt_craft_level.Text = "";
            txt_craft_exp.Text = "";
            txt_craft_batch.Text = "";
            txt_price.Text = "";
            btn_save.Text = "Save";
            btn_craft.Enabled = false;
        }

        void susun_item()
        {
            string s = cmb_name.Text;
            DataSet ds = lite.get_dataset(@"select item_name from tbl_item");
            item_name = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                item_name[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            cmb_name.Items.Clear();
            cmb_name.Items.AddRange(item_name);
            cmb_name.SelectedIndex = cmb_name.Items.IndexOf(s);
        }

        bool condition_meet()
        {
            bool hsl = false;
            if (cmb_name.Text == "") hsl = false;
            else
            {
                if (cmb_type.SelectedIndex < 0) hsl = false;
                else
                {
                    if (cmb_craftable.SelectedIndex < 0) hsl = false;
                    else
                    {
                        if (txt_level.Text == "") hsl = false;
                        else
                        {
                            if (txt_craft_level.Text == "") hsl = false;
                            else
                            {
                                if (txt_craft_exp.Text == "") hsl = false;
                                else
                                {
                                    if (txt_craft_batch.Text == "") hsl = false;
                                    else
                                    {
                                        if (txt_price.Text == "") hsl = false;
                                        else
                                            hsl = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return hsl;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (condition_meet())
            {
                string
                    item_name = cmb_name.Text,
                    item_type = cmb_type.Items[cmb_type.SelectedIndex].ToString(),
                    item_craftable = cmb_craftable.Items[cmb_craftable.SelectedIndex].ToString();
                int
                    item_level = Convert.ToInt32(txt_level.Text),
                    item_craft_level = Convert.ToInt32(txt_craft_level.Text),
                    item_craft_exp = Convert.ToInt32(txt_craft_exp.Text),
                    item_craft_batch = Convert.ToInt32(txt_craft_batch.Text),
                    item_price = Convert.ToInt32(txt_price.Text);
                progressBar1.Value = 100;
                if (btn_save.Text == "Save")
                {
                    string q = @"insert into tbl_item values('" + item_name + "','" + item_type + "','" + item_craftable + "'," + item_level + "," + item_craft_level + "," + item_craft_exp + "," + item_craft_batch + "," + item_price + ")";
                    MessageBox.Show(lite.insert_data(q) + " data telah tersimpan", "Informasi", MessageBoxButtons.OK);
                }
                else if (btn_save.Text == "Update")
                {
                    string q = @"update tbl_item set item_name='" + item_name + "', item_type='" + item_type + "', item_craftable='" + item_craftable + "', item_level=" + item_level + ", item_craft_level=" + item_craft_level + ", item_craft_exp=" + item_craft_exp + ", item_craft_batch=" + item_craft_batch + ", item_price=" + item_price + " where item_name='" + item_name + "'";
                    MessageBox.Show(lite.insert_data(q) + " data telah terupdate", "Informasi", MessageBoxButtons.OK);
                }
                susun_item();
                item_check();
            }
            else
                MessageBox.Show("Silahkan isi form yang kosong", "Informasi", MessageBoxButtons.OK);
        }

        private void btn_craft_Click(object sender, EventArgs e)
        {
            btn_craft.Enabled = false;
            form_craft f = new form_craft();
            f.Owner = this;
            f.Controls.Find("txt_item_name", true)[0].Text = cmb_name.Items[cmb_name.SelectedIndex].ToString();
            f.Shown += delegate
            {
                f.check_craft();
            };
            f.Show();
        }

        private void form_item_LocationChanged(object sender, EventArgs e)
        {
            if (this.OwnedForms.Count() > 0)
            {
                form_craft f = (form_craft)this.OwnedForms[0];
                f.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            }
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////string s = cmb_name.Text;
            //DataSet ds = lite.get_dataset(@"select item_name from tbl_item where item_type='" + cmb_type.Items[cmb_type.SelectedIndex].ToString() + "'");
            //item_name = new string[ds.Tables[0].Rows.Count];
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    item_name[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            //}
            //cmb_name.Items.Clear();
            //cmb_name.Items.AddRange(item_name);
            //cmb_name.SelectedIndex = -1;
            //cmb_name.Text = "pilih item";
            ////cmb_name.SelectedIndex = cmb_name.Items.IndexOf(s);
        }

    }
}

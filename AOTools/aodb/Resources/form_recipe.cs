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
using System.Data.SQLite;

namespace aodb
{
    public partial class form_recipe : Form
    {
        public class MethodItem
        {
            public string Name { get; set; }
            public StringMatchingMethod Value { get; set; }
        }

        int count_btn = 0, count_txt = 0, count_cmb = 0, pos_btn = 0, pos_txt = 1, pos_cmb = 1;
        SQLiteConnection conn;
        string[] item_name;
        private Resources.mySQLITE lite;

        public form_recipe()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source = aodb.db");
            lite = new Resources.mySQLITE();
        }

        private void form_recipe_Shown(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            load_item_name();
        }

        private void form_recipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((form_main)MdiParent).addRecipeToolStripMenuItem.Enabled = true;
        }

        private void combo_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_data.Controls.Clear();

            count_btn = 0;
            pos_btn = 0;

            count_txt = 0;
            pos_txt = 1;

            count_cmb = 0;
            pos_cmb = 1;

            load_button_add();
        }

        void load_item_name()
        {
            DataSet ds = lite.get_dataset("select item_name from tbl_item", conn);
            item_name = new string[ds.Tables[0].Rows.Count];
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                item_name[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
            }
            combo_name.Items.AddRange(item_name);
        }

        void load_cmb_add()
        {
            EasyCompletionComboBox cmb_add = new EasyCompletionComboBox();
            cmb_add.Name = "cmb_add_" + count_cmb.ToString();
            cmb_add.Size = new Size(205, 21);
            cmb_add.Location = new Point(23, pos_cmb);
            cmb_add.Text = "Pilih item";
            cmb_add.MatchingMethod = StringMatchingMethod.NoWildcards;
            cmb_add.Items.AddRange(item_name);
            cmb_add.Tag = count_cmb.ToString();

            count_cmb += 1;
            pos_cmb += 23;

            panel_data.Controls.Add(cmb_add);
        }

        void load_txt_add()
        {
            TextBox txt_add = new TextBox();
            txt_add.Name = "txt_add_" + count_txt.ToString();
            txt_add.Size = new Size(100, 20);
            txt_add.Text = "1";
            txt_add.Location = new Point(23 + 205 + 1, pos_txt);
            txt_add.Tag = count_txt.ToString();
            txt_add.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            count_txt += 1;
            pos_txt += 23;

            panel_data.Controls.Add(txt_add);
        }

        void load_button_add()
        {
            Button btn_add = new Button();
            btn_add.Name = "btn_add_" + count_btn.ToString();
            btn_add.Size = new Size(23, 23);
            btn_add.Text = "+";
            btn_add.Location = new Point(0, pos_btn);
            btn_add.Tag = count_btn.ToString();

            count_btn += 1;
            pos_btn += 23;

            panel_data.Controls.Add(btn_add);

            btn_add.Click += (s, e) =>
            {
                Button target_btn = (Button)s;
                TextBox target_txt = new TextBox();
                EasyCompletionComboBox target_cmb = new EasyCompletionComboBox();

                if (target_btn.Text == "+")
                {
                    load_button_add();
                    load_txt_add();
                    load_cmb_add();
                    target_btn.Text = "-"; 
                }
                else
                {
                    int x = Convert.ToInt32(target_btn.Name.Substring(8));
                    target_txt = (TextBox)panel_data.Controls["txt_add_" + x.ToString()];
                    target_cmb = (EasyCompletionComboBox)panel_data.Controls["cmb_add_" + x.ToString()];
                    List<Button> list_btn = new List<Button>();
                    List<TextBox> list_txt = new List<TextBox>();
                    List<EasyCompletionComboBox> list_cmb = new List<EasyCompletionComboBox>();

                    foreach (Control c in panel_data.Controls)
                    {
                        if (c.GetType() == typeof(Button))
                        {
                            if (Convert.ToInt32(((Button)c).Name.Substring(8)) > x)
                            {
                                list_btn.Add((Button)c);
                            }
                        }
                        else if (c.GetType() == typeof(TextBox))
                        {
                            if (Convert.ToInt32(((TextBox)c).Name.Substring(8)) > x -1)
                            {
                                list_txt.Add((TextBox)c);
                            }
                        }
                        else if (c.GetType() == typeof(EasyCompletionComboBox))
                        {
                            if (Convert.ToInt32(((EasyCompletionComboBox)c).Name.Substring(8)) > x - 1)
                            {
                                list_cmb.Add((EasyCompletionComboBox)c);
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
                    if (list_txt.Count > 0)
                    {
                        foreach (TextBox b in list_txt)
                        {
                            int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                            b.Location = new Point(b.Location.X, b.Location.Y - 23);
                            string q = b.Name.Remove(8);
                            q = q.Insert(8, y.ToString());
                            b.Name = q;
                            //b.Text = b.Name;
                        }
                    }
                    if (list_cmb.Count > 0)
                    {
                        foreach (EasyCompletionComboBox b in list_cmb)
                        {
                            int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                            b.Location = new Point(b.Location.X, b.Location.Y - 23);
                            string q = b.Name.Remove(8);
                            q = q.Insert(8, y.ToString());
                            b.Name = q;
                            //b.Text = b.Name;
                        }
                    }
                    count_btn -= 1;
                    pos_btn -= 23;
                    count_txt -= 1;
                    pos_txt -= 23;
                    count_cmb -= 1;
                    pos_cmb -= 23;
                    target_btn.Dispose();
                    target_txt.Dispose();
                    target_cmb.Dispose();
                }
            };
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (combo_name.SelectedIndex > -1)
            {
                int count = 0;
                foreach (Control c in panel_data.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                        count += 1;
                }
                if (count > 0)
                {
                    var list_txt = new List<TextBox>();
                    string recipe = "";
                    string[] item = new string[count];
                    bool recipe_status = false;
                    for (int i = 0; i < count; i++)
                    {
                        var cmb = (EasyCompletionComboBox)panel_data.Controls.Find("cmb_add_" + i.ToString(), true)[0];
                        if (cmb.SelectedIndex < 0)
                        {
                            MessageBox.Show("Silahkan pilih recipe item", "Informasi", MessageBoxButtons.OK);
                            recipe_status = false;
                            break;
                        }
                        else
                            recipe_status = true;
                        var txt = (TextBox)panel_data.Controls.Find("txt_add_" + i.ToString(), true)[0];
                        if (txt.Text == "" || txt.Text == "0")
                        {
                            MessageBox.Show("Silahkan isi jumlah item", "Informasi", MessageBoxButtons.OK);
                            recipe_status = false;
                            break;
                        }
                        else
                            recipe_status = true;
                        item[i] = cmb.Items[cmb.SelectedIndex].ToString() + "(" + txt.Text + ")";
                    }
                    if (recipe_status)
                    {
                        recipe = string.Join(",", item);
                        string target_item = combo_name.Items[combo_name.SelectedIndex].ToString();
                        if (target_item == lite.get_datacell(@"select recipe_name from tbl_recipe where recipe_name ='" + target_item + "'", conn).ToString())
                        {
                            MessageBox.Show("Recipe item sudah ada", "Informasi", MessageBoxButtons.OK);
                        }
                        else
                        {
                            string query = @"insert into tbl_recipe values ('" + target_item + "','" + recipe + "')";
                            MessageBox.Show(lite.insert_data(query, conn).ToString() + " Data telah tersimpan", "Informasi", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                    MessageBox.Show("Silahkan isi kombinasi item", "Informasi", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Silahkan pilih item", "Informasi", MessageBoxButtons.OK);
        }
    }
}

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
    public partial class AOCraft : Form
    {
        #region variables

        SQLiteConnection conn;
        SQLiteDataAdapter da;
        DataSet ds;
        string query, current_item;
        int i_current = -1, i_target = -1, i_type = -1, i_item = -1;

        #endregion variables

        #region method

        public AOCraft()
        {
            conn = new SQLiteConnection("Data Source = AOCraft.db");
            ds = new DataSet();
            InitializeComponent();
            InitializeEvent();
            panel_hitung.Visible = false;
            panel_detail.Visible = false;
            dgv_craft_plan.RowHeadersVisible = false;
        }

        public void InitializeEvent()
        {
            this.Shown += delegate
            {
                query = @"select * from craft_type";
                ds.Clear();
                ds = getDs(query);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    combo_craft_type.Items.Add(ds.Tables[0].Rows[i].ItemArray[0]);
                }
                for (int i = 1; i <= 120; i++)
                {
                    combo_current.Items.Add(i);
                    combo_target.Items.Add(i);
                }
                this.Location = new Point(0, 0);
            };
            combo_craft_type.SelectedIndexChanged += (s, e) =>
            {
                panel_detail.Visible = false;
                panel_hitung.Visible = false;
                i_type = combo_craft_type.SelectedIndex;
                view_item();
                view_plan();
            };
            text_current.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                } 
            };
            combo_current.SelectedIndexChanged += (s, e) =>
            {
                i_current = combo_current.SelectedIndex;
                query = @"select exp from craft_exp where level = " + Convert.ToInt32(combo_current.Items[i_current]) + "";
                text_current.Text = getData(query).ToString(); //Convert.ToInt32(getData(query)).ToString("#,0");
                //view_item();
                kalkulasi();
            };
            combo_target.SelectedIndexChanged += (s, e) =>
            {
                i_target = combo_target.SelectedIndex;
                query = @"select exp from craft_exp where level = " + Convert.ToInt32(combo_target.Items[i_target]) + "";
                text_target.Text = getData(query).ToString(); //Convert.ToInt32(getData(query)).ToString("#,0");
                kalkulasi();
            };
            list_craft_item.SelectedIndexChanged += delegate
            {
                panel_detail.Visible = true;
                i_item = list_craft_item.SelectedIndex;
                current_item = list_craft_item.Items[i_item].ToString().Split('-').GetValue(1).ToString().Trim();
                text_nama.Text = current_item;
                text_type.Text = combo_craft_type.Items[i_type].ToString();
                //query = @"select level from craft_item where nama = '" + current_item + "'";
                //text_level.Text = getData(query).ToString();
                query = @"select level_craft from craft_item where nama = '" + current_item + "'";
                text_level_craft.Text = getData(query).ToString();
                query = @"select exp_craft from craft_item where nama = '" + current_item + "'";
                text_exp_craft.Text = getData(query).ToString();
                query = @"select batch from craft_item where nama = '" + current_item + "'";
                text_batch.Text = getData(query).ToString();
                kalkulasi();
            };
        }

        public DataSet getDs(string q)
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

        public object getData(string q)
        {
            object hsl = null;
            using (var cmd = new SQLiteCommand(q, conn))
            {
                conn.Open();
                hsl= cmd.ExecuteScalar();
                conn.Close();
            }
            return hsl;
        }

        public void view_item()
        {
            list_craft_item.Items.Clear();
            //if (i_type > -1 && i_current> -1)
            //{
                query = @"select nama, level_craft from craft_item where type = '" + combo_craft_type.Items[i_type].ToString() + "' order by level_craft asc";// and level_craft <= " + Convert.ToInt32(combo_current.Items[i_current]) + "";
                ds.Clear();
                ds = getDs(query);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    current_item = ds.Tables[0].Rows[i].ItemArray[1].ToString() + " - " + ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    list_craft_item.Items.Add(current_item);
                }
            //}
        }

        public void kalkulasi()
        {
            panel_hitung.Visible = false;
            if (i_current > -1 && i_target > -1 && i_item > -1)
            {
                int current_level = Convert.ToInt32(combo_current.Items[i_current]),
                    current_item_level_craft = Convert.ToInt32(text_level_craft.Text);
                if (current_level > 0 && current_item_level_craft > 0)
                {
                    if (combo_target.SelectedIndex > combo_current.SelectedIndex && current_level >= current_item_level_craft)
                    {
                        panel_hitung.Visible = true;
                        int current_exp = Convert.ToInt32(text_current.Text),
                            target_exp = Convert.ToInt32(text_target.Text),
                            craft_exp = Convert.ToInt32(text_exp_craft.Text),
                            craft_batch = Convert.ToInt32(text_batch.Text);

                        text_t_exp.Text = (target_exp - current_exp).ToString();
                        text_t_craft.Text = (Math.Ceiling((double)(target_exp - current_exp) / craft_exp) * craft_batch).ToString();
                        text_t_final.Text = (Math.Ceiling((double)(target_exp - current_exp) / craft_exp) * craft_exp).ToString();
                    }
                }
            }
        }

        public void view_plan()
        {
            query = @"select * from craft_plan where type='" + combo_craft_type.Items[i_type] + "' order by level_current asc";
            ds.Tables.Clear();
            ds = getDs(query);
            ds.Tables[0].Columns.RemoveAt(1);
            Program.ds = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgv_craft_plan.Rows.Clear();
                dgv_craft_plan.Rows.Add(ds.Tables[0].Rows.Count);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        dgv_craft_plan.Rows[i].Cells[j].Value = ds.Tables[0].Rows[i].ItemArray[j];
                    }
                }
                btn_craft_plan.Visible = true;
                dgv_craft_plan.Visible = true;
            }
            else
            {
                btn_craft_plan.Visible = false;
                dgv_craft_plan.Visible = false;
            }
        }

        private void btn_save_plan_Click(object sender, EventArgs e)
        {
            string nama = text_nama.Text, type = text_type.Text;
            int current = Convert.ToInt32(combo_current.Items[i_current]),
                target = Convert.ToInt32(combo_target.Items[i_target]),
                batch = Convert.ToInt32(text_t_craft.Text);
            query = @"insert into craft_plan values ('" + nama + "','" + type + "'," + current + "," + target + "," + batch + ")";
            using (var cmd = new SQLiteCommand(query, conn))
            {
                conn.Open();
                MessageBox.Show(cmd.ExecuteNonQuery().ToString() + " Record telah disimpan", "Informasi", MessageBoxButtons.OK);
                
                conn.Close();
            }
            view_plan();
        }

        private void btn_craft_plan_Click(object sender, EventArgs e)
        {
            CraftPlan f = new CraftPlan();
            f.ShowDialog();
        }

        private void btn_recipe_Click(object sender, EventArgs e)
        {
            CraftRecipe c = new CraftRecipe();
            c.ShowDialog();
        }

        #endregion method
    }
}

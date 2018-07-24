using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOCraft
{
    public partial class CraftPlan : Form
    {
        public CraftPlan()
        {
            InitializeComponent();
            dgv_craft_plan_list.RowHeadersVisible = false;
            DataSet ds = Program.ds;
            this.Shown += delegate
            {
                this.Location = new Point(0, 0);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgv_craft_plan_list.Rows.Clear();
                    dgv_craft_plan_list.Rows.Add(ds.Tables[0].Rows.Count);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                        {
                            dgv_craft_plan_list.Rows[i].Cells[j].Value = ds.Tables[0].Rows[i].ItemArray[j];
                        }
                    }
                }
            };
        }
    }
}

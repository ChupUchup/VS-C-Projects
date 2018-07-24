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
using System.Data.OleDb;

namespace MyHarvestmoon
{
    public partial class MyHarvestmoonApp : Form
    {
        public MyHarvestmoonApp()
        {
            InitializeComponent();
        }
        private form_data fdata;
        private form_gift fgift;
        
        private void MyHarvestmoonApp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            try { isi_namelist(); }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            if (fdata == null || !fdata.IsHandleCreated)
            {
                fdata = new form_data();
                fdata.ShowDialog();
            }
        }

        private void isi_namelist()
        {
            OleDbCommand cmd = Program.global_conn.CreateCommand();
            OleDbDataReader reader;
            cmd.CommandText = @"select character_name from tbl_character";
            cmd.Connection = Program.global_conn;
            Program.global_conn.Open();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read()) list_name.Items.Add(reader.GetString(0));
            }
            reader.Close();
            Program.global_conn.Close();
        }

        private void list_name_SelectedValueChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = Program.global_conn.CreateCommand();
            OleDbDataReader reader;
            cmd.CommandText = @"select* from tbl_character where character_name='" + list_name.SelectedItem + "'";
            cmd.Connection = Program.global_conn;
            Program.global_conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                listBox1.Items.Clear(); listBox2.Items.Clear(); listBox3.Items.Clear(); listBox4.Items.Clear(); listBox5.Items.Clear();
                while (reader.Read())
                {
                    foreach (string i in reader.GetString(1).Split(',')) listBox1.Items.Add(i);
                    foreach (string i in reader.GetString(2).Split(',')) listBox2.Items.Add(i);
                    foreach (string i in reader.GetString(3).Split(',')) listBox3.Items.Add(i);
                    foreach (string i in reader.GetString(4).Split(',')) listBox4.Items.Add(i);
                    foreach (string i in reader.GetString(5).Split(',')) listBox5.Items.Add(i);
                }
            }
            reader.Close();
            Program.global_conn.Close();
        }

        private void btn_add_gift_Click(object sender, EventArgs e)
        {
            if (fgift == null || !fgift.IsHandleCreated)
            {
                fgift = new form_gift();
                fgift.ShowDialog();
            }
        }
    }
}

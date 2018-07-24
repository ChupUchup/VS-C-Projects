using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace MyHarvestmoon
{
    public partial class form_gift : Form
    {
        public form_gift()
        {
            InitializeComponent();
        }
        private string dataname = "list_gift.txt";
        private List<string> data_gift = new List<string>();

        private void form_gift_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            btn_insert.Enabled = false;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_gift.Text.Length > 0)
                {
                    txt_gift.Text = txt_gift.Text.Replace(" and ", ",").ToLower();
                    myReader(ref data_gift);
                    string[] temp = txt_gift.Text.Split(',');
                    data_gift.AddRange(temp);
                    //data_gift = data_gift.Select(d => d.ToLower()).ToList();
                    data_gift = data_gift.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
                    data_gift.Distinct();
                    data_gift.Sort();
                    myWriter(ref data_gift);
                    //list_gift.DataSource = data_gift;
                    //lbl_total.Text = "Total : " + (data_gift.Count.ToString());
                    btn_load_Click(null, null);
                }
                else { MessageBox.Show("Tidak ada data yang akan disimpan", "Info", MessageBoxButtons.OK); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                txt_gift.Clear();
                myReader(ref data_gift);
                txt_gift.Text = string.Join(",", data_gift);
                list_gift.DataSource = data_gift;
                lbl_total.Text = "Total : " + (data_gift.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void myReader(ref List<string>data_list)
        {
            try
            {
                using (FileStream fs = new FileStream(dataname, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line;
                        data_list.Clear();
                        while ((line = sr.ReadLine()) != null) data_list.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void myWriter(ref List<string> data_list)
        {
            try
            {
                //using (FileStream fs = new FileStream(dataname, FileMode.Open, FileAccess.Write))
                //{
                //    using (StreamWriter sw = new StreamWriter(fs))
                //    {
                //        foreach (string i in data_list) sw.WriteLine(i.Trim('\n', ' '));
                //    }
                //}
                using (StreamWriter sw = new StreamWriter(dataname))
                {
                    foreach (string i in data_list) sw.WriteLine(i.Trim('\n', ' '));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_gift.Clear();
        }

        private void txt_gift_TextChanged(object sender, EventArgs e)
        {
            if (txt_gift.Text.Length > 0) btn_insert.Enabled = true;
            else btn_insert.Enabled = false;
        }

        private void menu_delete_Click(object sender, EventArgs e)
        {
            data_gift.Clear();
            data_gift = list_gift.Items.Cast<object>().Select(i => i.ToString()).ToList();
            data_gift.Remove(list_gift.SelectedItem.ToString());
            myWriter(ref data_gift);
            int pos = list_gift.SelectedIndex;
            btn_load_Click(null, null);
            //list_gift.DataSource = data_gift;
            list_gift.SelectedIndex = pos - 1;
            //lbl_total.Text = "Total : " + (data_gift.Count.ToString());
        }
    }
}

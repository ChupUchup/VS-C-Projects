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

namespace HM_Gift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form_InputData finput;
        private string filename = "HM_Gift.txt";
        private List<string> data_gift = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            if (!File.Exists(filename)) File.CreateText(filename);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            Read_Data();
            if (pase_1.Checked) data_gift = data_gift.Select(i => i.ToLower()).ToList();
            else if (pase_2.Checked) data_gift = data_gift.Select(i => i.Trim(' ', '\n', ',')).ToList();
            else if (pase_3.Checked)
            {
                data_gift.RemoveAll(i => i == "loves");
                data_gift.RemoveAll(i => i == "likes");
                data_gift.RemoveAll(i => i == "neutral");
                data_gift.RemoveAll(i => i == "dislikes");
                data_gift.RemoveAll(i => i == "hates");
            }
            else if (pase_4.Checked) data_gift = data_gift.Where(i => !string.IsNullOrWhiteSpace(i)).ToList();
            else if (pase_5.Checked) data_gift = data_gift.Select(i => i.Replace(" and ", ",")).ToList();
            else if (pase_6.Checked)
            {
                richTextBox1.Text = string.Join(",", data_gift);
                data_gift.Clear();
                data_gift.Add(richTextBox1.Text);
            }
            else if (pase_7.Checked)
            {
                data_gift = data_gift.Select(i => i.Replace(",,", ",")).ToList();
                string x = data_gift[0]; data_gift.Clear();
                data_gift.AddRange(x.Split(','));
                data_gift.Sort();
                data_gift = data_gift.Distinct().ToList();
            }
            if (check_write.Checked) Write_Data();
            Refresh_Form();
        }

        private void menu_delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                data_gift.Clear();
                data_gift = listBox1.Items.Cast<object>().Select(i => i.ToString()).ToList();
                data_gift.Remove(listBox1.SelectedItem.ToString());
                int pos = listBox1.SelectedIndex;
                Write_Data();
                Refresh_Form();
                listBox1.SelectedIndex = pos - 1;
            }
        }

        private void Refresh_Form()
        {
            richTextBox1.Text = string.Join(", ", data_gift);
            listBox1.DataSource = data_gift; listBox1.Invalidate();
            lbl_count.Text = "Count : " + (listBox1.Items.Count.ToString());
        }

        private void Read_Data()
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string temp; data_gift.Clear();
                    while ((temp = sr.ReadLine()) != null) data_gift.Add(temp);
                }
            }
        }

        private void Write_Data()
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (string i in data_gift) sw.WriteLine(i);
            }
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            if (finput == null || !finput.IsHandleCreated)
            {
                finput = new Form_InputData();
                finput.ShowDialog();
            }
        } 
    }
}

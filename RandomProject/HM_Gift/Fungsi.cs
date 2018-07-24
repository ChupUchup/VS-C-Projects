using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace HM_Gift
{
    public class Fungsi
    {
        public List<string> Reader(string fname)
        {
            List<string> hsl = new List<string>();
            try
            {
                using (FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string tmp;
                        while ((tmp = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(tmp) && !tmp.Contains("likes and dislikes"))
                            {
                                hsl.Add(tmp.ToLower().Trim(' ', ',').Replace(" and ", ", "));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
            }
            return hsl;
        }

        public bool Writer(string fname, List<string> data)
        {
            bool hsl = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(fname))
                {
                    foreach (string i in data) sw.WriteLine(i);
                    hsl = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
            }
            return hsl;
        }

        public void Tampil(List<string>data, RichTextBox txt, ListBox lst = null)
        {
            try
            {
                txt.Text = string.Join("\n", data);
                if (lst != null) lst.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
            }
        }
    }
}

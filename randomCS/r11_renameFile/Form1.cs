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

namespace r11_renameFile
{
    public partial class Form1 : Form
    {
        FileInfo[] dirFiles;
        string dirLoc;
        public Form1()
        {
            InitializeComponent();
            txtKeyword.Enabled = false;
            btnProses.Enabled = false;
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (!f.SelectedPath.Equals(""))
                {
                    dirLoc = f.SelectedPath;
                    txtDirLoc.Text = dirLoc;
                    getFileList();
                    labelFile.Text = "File : " + listFile.Items.Count.ToString();
                    txtKeyword.Enabled = true;
                }
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtKeyword.TextLength > 0) btnProses.Enabled = true;
            else btnProses.Enabled = false;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (dirFiles.Count() > 0)
            {
                foreach (FileInfo ff in dirFiles)
                {
                    //if (ff.FullName.Contains(txtKeyword.Text))
                    //{
                    //    File.Copy(ff.FullName, ff.FullName.Replace(txtKeyword.Text, ""));
                    //    File.Delete(ff.FullName);
                    //}
                    if (Char.IsNumber(ff.Name, 0))
                    {
                        File.Copy(ff.FullName, ff.Directory + "\\" + ff.Name.Remove(0, 4));
                        File.Delete(ff.FullName);
                    }
                }
                getFileList();
            }
        }
        private void getFileList()
        {
            listFile.Items.Clear();
            dirFiles = new DirectoryInfo(dirLoc).GetFiles();
            //listFile.Items.AddRange(dirFiles);
            foreach (FileInfo ff in dirFiles) listFile.Items.Add(ff.FullName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != "")
                {
                    textBox1.Text = ofd.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text.Replace(textBox2.Text, "-");
            File.Copy(textBox1.Text, t);
            File.Delete(textBox1.Text);
        }
    }
}

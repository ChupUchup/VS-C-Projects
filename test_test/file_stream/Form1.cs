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

namespace file_stream
{
    public partial class Form1 : Form
    {
        FileStream fs;
        List<int> myList;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string filename = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!ofd.FileName.Equals(""))
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);
                    myList = new List<int>();
                    FileInfo info = new FileInfo(ofd.FileName);
                    
                    for (int i = 0; i < info.Length; i++)
                    {
                        int x = fs.ReadByte();
                        if (x > 255) MessageBox.Show((Convert.ToChar(Convert.ToInt32(x))).ToString() + " lebih besar 255");
                        else { myList.Add(fs.ReadByte()); }
                    }
                    foreach (byte i in myList) richTextBox1.Text += (char)i;
                }
            }
        }
    }
}

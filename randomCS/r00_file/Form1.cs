//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace r00_file
{
    public partial class Form1 : Form
    {
        string _currentFileFullName, _currentFileName, _currentFileExtension, _currentFileDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName != "")
                {
                    FileInfo f = new FileInfo(ofd.FileName);
                    _currentFileFullName = ofd.FileName;
                    _currentFileName = f.Name;
                    _currentFileExtension = f.Extension;
                    _currentFileDirectory = f.DirectoryName;
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(new string[] { _currentFileFullName, _currentFileName, _currentFileExtension, _currentFileDirectory });
                }
            }
        }
    }
}

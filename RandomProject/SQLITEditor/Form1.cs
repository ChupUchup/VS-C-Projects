using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SQLITEditor
{
    public partial class Form1 : Form
    {
        string currentDirPath, currentDirName;
        public Form1()
        {
            InitializeComponent();
            InitializeEvent();
        }
        
        void InitializeEvent()
        {
            this.Shown += delegate
            {
                checkDir();
            };
            treeView1.BeforeSelect += (obj, s) =>
            {
                label1.Text=s.Node.Text;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text;
            if (!fileName.Contains(".db")) fileName = string.Concat(fileName, ".db");
            string filePath = currentDirPath + "//" + fileName;
            SQLiteConnection.CreateFile(filePath);
            checkDir();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = sender.ToString();
        }

        void checkDir()
        {
            currentDirPath = Application.StartupPath;
            currentDirName = new DirectoryInfo(currentDirPath).Name;
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("dir", currentDirName);
            foreach(object o in new DirectoryInfo(currentDirPath).GetFiles("*.db"))
            {
                treeView1.Nodes["dir"].Nodes.Add(o.ToString(), o.ToString());
                treeView1.Nodes["dir"].Nodes[o.ToString()].ContextMenuStrip = contextMenuStrip1;
            }
            treeView1.Nodes["dir"].Expand();
        }
    }
}

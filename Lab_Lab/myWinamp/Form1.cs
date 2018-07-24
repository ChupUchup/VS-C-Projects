using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;
using WMPLib;

namespace myWinamp
{
    public partial class Form1 : Form
    {
        struct Playlist
        {
            public string nama;
            public string lokasi;
        };
        int x=0, y=0;
        List<Playlist> myPlaylist = new List<Playlist>();
        //string filename = "";
        //List<string> playlist = new List<string>();
        //WindowsMediaPlayer player = new WindowsMediaPlayer();
        
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.settings.autoStart = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!ofd.FileNames.Equals(""))
                {
                    foreach (var i in ofd.FileNames)
                    {
                        FileInfo FI = new FileInfo(i);
                        Playlist temp = new Playlist();
                        temp.nama = FI.Name;
                        temp.lokasi = i;
                        myPlaylist.Add(temp);
                        listBox1.Items.Add(FI.Name);
                    }
                    listBox1.Invalidate();
                }
                if (myPlaylist.Count > 0)
                {
                    listBox1.SelectedIndex = 0;
                    axWindowsMediaPlayer1.settings.autoStart = true;
                }
            }
            ofd.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myPlaylist.Count > 0)
            {
                axWindowsMediaPlayer1.URL = myPlaylist[listBox1.SelectedIndex].lokasi;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = MousePosition.X - this.Location.X; //if (x < 0) x *= -1;
            y = MousePosition.Y - this.Location.Y; //if (y < 0) y *= -1;
            this.MouseMove += ubah_posisi;
        }

        private void ubah_posisi(object s, MouseEventArgs e)
        {
            this.Location = new Point(MousePosition.X - x, MousePosition.Y - y);
            //x = MousePosition.X - this.Location.X;
            //y = MousePosition.Y - this.Location.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseMove -= ubah_posisi;
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        if (ofd.FileName != "")
        //        {
        //            filename = ofd.FileName;
        //            FileInfo FI = new FileInfo(ofd.FileName);
        //            axWindowsMediaPlayer1.URL = filename;
        //            //textBox1.Text = FI.Name;}
        //        }
        //    }
        //}
    }
}

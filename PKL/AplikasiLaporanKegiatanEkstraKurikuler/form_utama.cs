using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLib;
using System.IO;

namespace AplikasiLaporanKegiatanEkstraKurikuler
{
    public partial class form_utama : Form
    {
        private static form_kegiatan f_kegiatan;
        private static form_siswa f_siswa;
        private static form_guru f_guru;
        public LibSqlite sqlite;

        public form_utama()
        {
            InitializeComponent();
        }

        private void form_utama_Shown(object sender, EventArgs e)
        {
            if (File.Exists("AplikasiLaporanKegiatanEkstraKurikuler.db"))
            {
                sqlite = new LibSqlite("Data Source = AplikasiLaporanKegiatanEkstraKurikuler.db");
                form_login f = new form_login();
                f.Owner = this;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Database tidak ditemukan harap periksa kelengkapan aplikasi", "Informasi", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Belum ada fungsi", "Informasi", MessageBoxButtons.OK);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_login f = new form_login();
            f.Owner = this;
            f.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Belum ada fungsi", "Informasi", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kegiatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f_kegiatan == null || f_kegiatan.IsDisposed)
            {
                if (f_siswa != null) f_siswa.Close();
                if (f_guru != null) f_guru.Close();
                f_kegiatan = new form_kegiatan();
                f_kegiatan.MdiParent = this;
                f_kegiatan.Show();
            }
        }

        private void siswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f_siswa == null || f_siswa.IsDisposed)
            {
                if (f_kegiatan != null) f_kegiatan.Close();
                if (f_guru != null) f_guru.Close();
                f_siswa = new form_siswa();
                f_siswa.MdiParent = this;
                f_siswa.Show();
            }
        }

        private void guruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f_guru == null || f_guru.IsDisposed)
            {
                if (f_kegiatan != null) f_kegiatan.Close();
                if (f_siswa != null) f_siswa.Close();
                f_guru = new form_guru();
                f_guru.MdiParent = this;
                f_guru.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message =
                "Aplikasi Laporan Kegiatan Ekstra Kurikulier\n" +
                "Dibangun oleh : Andika Benu\n" +
                "Nik : H1G114216\n" +
                "Sebagai implementasi pada Praktik Kerja Lapangan\n"+
                "di SMK YPT BANJARMASIN";
            MessageBox.Show(message, "About", MessageBoxButtons.OK);
        }




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLaporanKegiatanEkstraKurikuler
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }


        private void form_login_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Silahkan login terlebih dahulu untuk dapat menggunakan aplikasi", "Informasi", MessageBoxButtons.OK);
        }

        


    }
}

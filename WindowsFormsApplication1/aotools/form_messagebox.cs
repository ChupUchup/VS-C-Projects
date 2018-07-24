using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aotools
{
    public partial class form_messagebox : Form
    {
        public form_messagebox()
        {
            InitializeComponent();
        }

        private void form_messagebox_Shown(object sender, EventArgs e)
        {
            string message =
                " Informasi".PadRight(10, ' ') + "untuk.vinnie@gmail.com".PadLeft(30, ' ') + " \n" +
                " H/U".PadRight(10, ' ') + "= Enable disable posisi mouse \n" +
                " Gear".PadRight(10, ' ') + "= Pilih target Atlantica \n" +
                " R/S".PadRight(10, ' ') + "= Run atau Stop automouse\n" +
                " Reset".PadRight(10, ' ') + "= Reset ya reset\n" +
                " ?".PadRight(10, ' ') + "= Show help \n" +
                " L".PadRight(10, ' ') + "= Left Click \n" +
                " R".PadRight(10, ' ') + "= Right Click \n" +
                " Delay".PadRight(10, ' ') + "= Jeda waktu untuk setiap posisi \n" +
                " Ulang".PadRight(10, ' ') + "= Mau di ulang berapa kali ? \n" +
                " Shortcut".PadRight(10, ' ') + " \n" +
                " F11".PadRight(10, ' ') + "= Simpan posisi mouse \n";
            richTextBox1.Text = message;
        }
    }
}

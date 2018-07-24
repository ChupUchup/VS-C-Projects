using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aodb
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void form_main_Shown(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void addRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addRecipeToolStripMenuItem.Enabled = false;
            form_recipe target_form = new form_recipe();
            target_form.MdiParent = this;
            target_form.Show();
        }
    }
}

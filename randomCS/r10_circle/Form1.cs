using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r10_circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += delegate
            {
                Label l = new Label();
                l.Location = new Point(0, 0);
                this.Controls.Add(l);
                int r = 10, d = 20;

            };
        }
    }
}

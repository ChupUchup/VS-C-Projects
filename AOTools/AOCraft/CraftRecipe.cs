using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOCraft
{
    public partial class CraftRecipe : Form
    {

        #region variables

        #endregion variables

        #region method

        public CraftRecipe()
        {
            InitializeComponent();
            InitializeEvent();
        }

        void InitializeEvent()
        {
            this.Shown += delegate
            {
                this.Location = new Point(0, 0);
            };
        }

        private void btn_input_item_Click(object sender, EventArgs e)
        {
            InputItem i = new InputItem();
            i.ShowDialog();
        }

        #endregion method
    }
}

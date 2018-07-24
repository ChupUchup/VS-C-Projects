using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        ListBox list_hint = new ListBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            add_textbox();
        }

        void add_textbox()
        {
            TextBox t = new TextBox();
            t.Size = new Size(200, 20);
            t.Location = new Point(0, 0);

            ListBox l = new ListBox();
            //l.Size = new Size(t.Width, t.Height * 10);
            //t.Location = new Point(t.Location.X, t.Location.Y + t.Size.Height);
            l.TextChanged += (s, e) =>
            {
                l.Items.Clear();
                l.Items.AddRange(new string[] { "a", "b", "c" });
            };
            l.SelectedIndexChanged += (s, e) =>
            {
                t.Text = ((ListBox)s).Items[((ListBox)s).SelectedIndex].ToString();
                t.SelectionStart = t.TextLength;
                l.Hide();
            };
            l.Hide();

            t.TextChanged += (s, e) =>
            {
                var target = (TextBox)s;
                l.Size = new System.Drawing.Size(target.Width, target.Height * 10);
                l.Location = new Point(target.Location.X, target.Location.Y + target.Size.Height);
                //l.Hide();
                if (target.Focused)
                {
                    if (string.IsNullOrWhiteSpace(target.Text))
                    {
                        l.Hide();
                        l.Text = "h";
                    }
                    else
                    {
                        l.Show();
                        l.Text = "s";
                    }
                }
                else
                {
                    l.Hide();
                    l.Text = "h";
                }
            };
            t.Disposed += (s, e) => { l.Dispose(); };
            this.Controls.Add(t);
            this.Controls.Add(l);
        }
    }
}

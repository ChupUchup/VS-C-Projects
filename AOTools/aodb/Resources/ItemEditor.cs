using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace aodb.Resources
{
    public class ItemEditor
    {
        int count_btn = 0, count_nma = 0, count_jlh = 0, count_hrg = 0,
            pos_btn = 0, pos_nma = 1, pos_jlh = 1, pos_hrg = 1;
        Panel panel_item = new Panel();

        public ItemEditor() { }

        public void Add(ref Panel p, int item_count, string item_name = "", int item_total = -1, int item_price = -1)
        {
            if (item_count == 0)
                btn_add(ref p);
            else
            {

            }
        }

        public void Reset()
        {
            count_btn = 0;
            count_nma = 0;
            count_jlh = 0;
            count_hrg = 0;
            pos_btn = 0;
            pos_nma = 1;
            pos_jlh = 1;
            pos_hrg = 1;
            panel_item = new Panel();
        }

        private void btn_add(ref Panel p)
        {
            //if (count_btn == 0)
            //{
            //    //this.Size = new Size(this.Size.Width, this.Size.Height + 13 + 23);
            //}
            Button add_btn = new Button();
            add_btn.Name = "btn_add_" + count_btn.ToString();
            add_btn.Size = new Size(23, 23);
            add_btn.Text = "+";
            add_btn.Location = new Point(0, pos_btn);
            add_btn.Click += (s, e) =>
            {
                Button btn_aad = (Button)s;
                ComboBox cmb_nma = new ComboBox();
                TextBox txt_jlh = new TextBox();
                TextBox txt_hrg = new TextBox();

                if (btn_aad.Text == "+")
                {
                    //this.Size = new Size(this.Size.Width, this.Size.Height + 21);
                    cmb_nama();
                    txt_jumlah();
                    txt_harga();
                    //btn_add();
                    btn_aad.Text = "-";
                }
                else
                {
                    //this.Size = new Size(this.Size.Width, this.Size.Height - 21);
                    int x = Convert.ToInt32(btn_aad.Name.Substring(8));
                    //cmb_nma = (ComboBox)panel_item.Controls["cmb_nma_" + x.ToString()];
                    txt_jlh = (TextBox)panel_item.Controls["txt_jlh_" + x.ToString()];
                    txt_hrg = (TextBox)panel_item.Controls["txt_hrg_" + x.ToString()];
                    List<Button> list_btn = new List<Button>();
                    List<ComboBox> list_nma = new List<ComboBox>();
                    List<TextBox> list_jlh = new List<TextBox>();
                    List<TextBox> list_hrg = new List<TextBox>();

                    foreach (Control c in panel_item.Controls)
                    {
                        if (c.GetType() == typeof(Button))
                        {
                            if (Convert.ToInt32(((Button)c).Name.Substring(8)) > x)
                            {
                                list_btn.Add((Button)c);
                            }
                        }
                        else if (c.GetType() == typeof(ComboBox))
                        {
                            if (Convert.ToInt32(((ComboBox)c).Name.Substring(8)) > x - 1)
                            {
                                list_nma.Add((ComboBox)c);
                            }
                        }
                        else if (c.GetType() == typeof(TextBox))
                        {
                            string z = ((TextBox)c).Name.Substring(4, 3);
                            if (Convert.ToInt32(((TextBox)c).Name.Substring(8)) > x - 1)
                            {
                                if (z == "jlh")
                                    list_jlh.Add((TextBox)c);
                                else if (z == "hrg")
                                    list_hrg.Add((TextBox)c);
                            }
                        }
                    }
                    if (list_btn.Count > 0)
                    {
                        foreach (Button b in list_btn)
                        {
                            int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                            b.Location = new Point(b.Location.X, b.Location.Y - 23);
                            string q = b.Name.Remove(8);
                            q = q.Insert(8, y.ToString());
                            b.Name = q;
                        }
                    }
                    if (list_nma.Count > 0)
                    {
                        foreach (ComboBox b in list_nma)
                        {
                            int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                            b.Location = new Point(b.Location.X, b.Location.Y - 23);
                            string q = b.Name.Remove(8);
                            q = q.Insert(8, y.ToString());
                            b.Name = q;
                        }
                    }
                    if (list_jlh.Count > 0)
                    {
                        foreach (TextBox b in list_jlh)
                        {
                            int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                            b.Location = new Point(b.Location.X, b.Location.Y - 23);
                            string q = b.Name.Remove(8);
                            q = q.Insert(8, y.ToString());
                            b.Name = q;
                        }
                    }
                    if (list_hrg.Count > 0)
                    {
                        foreach (TextBox b in list_hrg)
                        {
                            int y = Convert.ToInt32(b.Name.Substring(8)) - 1;
                            b.Location = new Point(b.Location.X, b.Location.Y - 23);
                            string q = b.Name.Remove(8);
                            q = q.Insert(8, y.ToString());
                            b.Name = q;
                        }
                    }
                    count_btn -= 1;
                    count_nma -= 1;
                    count_jlh -= 1;
                    count_hrg -= 1;
                    pos_btn -= 23;
                    pos_nma -= 23;
                    pos_jlh -= 23;
                    pos_hrg -= 23;
                    btn_aad.Dispose();
                    cmb_nma.Dispose();
                    txt_jlh.Dispose();
                    txt_hrg.Dispose();
                }
            };
            p.Controls.Add(add_btn);
            count_btn += 1;
            pos_btn += 23;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_nama()
        {
            ComboBox cmb_nma = new ComboBox();
            cmb_nma.Name = "cmb_nma_" + count_nma.ToString();
            cmb_nma.Size = new Size(150, 21);
            cmb_nma.Location = new Point(23, pos_nma);
            //cmb_nma.MatchingMethod = StringMatchingMethod.UseWildcards;
            //cmb_nma.Items.AddRange(item_name);
            cmb_nma.SelectedIndexChanged += cmb_nma_SelectedIndexChanged;
            panel_item.Controls.Add(cmb_nma);
            count_nma += 1;
            pos_nma += 23;
        }

        private void cmb_nma_SelectedIndexChanged(object sender, EventArgs e)
        {
            var target = (ComboBox)sender;
            int x = Convert.ToInt32(target.Name.Substring(8));
            int harga = 0;
            string q = @"select item_price from tbl_item where item_name='" + target.Items[target.SelectedIndex].ToString() + "'";
            var jlh = (TextBox)panel_item.Controls.Find("txt_jlh_" + x.ToString(), true)[0];
            //jlh.Text = jumlah.ToString();
            //harga = Convert.ToInt32(lite.get_datacell(q));
            var hrg = (TextBox)panel_item.Controls.Find("txt_hrg_" + x.ToString(), true)[0];
            hrg.Text = harga.ToString();

        }

        private void txt_jumlah()
        {
            TextBox txt_jlh = new TextBox();
            txt_jlh.Name = "txt_jlh_" + count_jlh.ToString();
            txt_jlh.Size = new Size(30, 20);
            txt_jlh.Location = new Point(23 + 150 + 1, pos_jlh);
            txt_jlh.Text = "1";
            txt_jlh.KeyPress += txt_jlh_KeyPress;
            txt_jlh.KeyDown += txt_jlh_KeyDown;
            panel_item.Controls.Add(txt_jlh);
            count_jlh += 1;
            pos_jlh += 23;
        }

        private void txt_jlh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //btn_save_Click(null, null);
            }
        }

        private void txt_jlh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_harga()
        {
            TextBox txt_hrg = new TextBox();
            txt_hrg.Name = "txt_hrg_" + count_hrg.ToString();
            txt_hrg.Size = new Size(53, 20);
            txt_hrg.Location = new Point(23 + 150 + 30 + 2, pos_hrg);
            txt_hrg.KeyPress += txt_jlh_KeyPress;
            txt_hrg.KeyDown += txt_jlh_KeyDown;
            panel_item.Controls.Add(txt_hrg);
            count_hrg += 1;
            pos_hrg += 23;
        }
    }
}

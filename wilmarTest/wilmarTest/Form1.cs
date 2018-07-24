using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wilmarTest
{
    public partial class Form1 : Form
    {
        enum toKalimat
        {
            satu = 1,
            dua = 2,
            tiga = 3,
            empat = 4,
            lima = 5,
            enam = 6,
            tujuh = 7,
            delapan = 8,
            sembilan = 9
        };
        Timer t;

        public Form1()
        {
            InitializeComponent();
            t = new Timer(); 
            t.Interval = 200;
            t.Tick += delegate
            {
                string input = lblBerjalan.Text;
                input = input + input.Substring(0, 1);
                input = input.Remove(0, 1);
                Invoke((Action)delegate
                {
                    lblBerjalan.Text = input;
                });
            };
        }

        private void btnPrima_Click(object sender, EventArgs e)
        {
            try
            {
                uint input = Convert.ToUInt32(txtPrimaIn.Text);
                string hsl = "";
                if (input > 1)
                {
                    txtPrimaIn.Enabled = false;
                    btnPrima.Enabled = false;
                    for (uint i = 2; i <= input; i++)
                    {
                        if (isPrima(i)) hsl += i + " ";
                    }
                    txtPrimaOut.Text = hsl;
                    txtPrimaIn.Enabled = true;
                    btnPrima.Enabled = true;
                    txtPrimaIn.Focus();
                }
                else txtPrimaOut.Text = "Input Harus Lebih Dari 1";
            }
            catch
            {
                txtPrimaOut.Text = "Invalid Input";
            }
        }

        private void txtPrimaIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnPrima_Click(null, null);
        }

        private void btnBerjalan_Click(object sender, EventArgs e)
        {
            try
            {
                if (t.Enabled) t.Enabled = false;
                else
                {
                    lblBerjalan.Text = txtBerjalan.Text + " ";
                    t.Enabled = true;
                }
            }
            catch
            {
                lblBerjalan.Text = "Invalid Input";
            }
        }

        private void txtBerjalan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (t.Enabled) lblBerjalan.Text = txtBerjalan.Text + " ";
                else btnBerjalan_Click(null, null);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                UInt64 input = Convert.ToUInt64(txtUbahIn.Text);
                txtUbahOut.Text = ubah(input);
            }
            catch
            {
                txtUbahOut.Text = "Invalid Input";
            }
        }

        private void txtUbahIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUbah_Click(null, null);
            }
        }

        private void numericSegitigaIn_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (numericSegitigaIn.Value > 0)
                {
                    UInt32 input = Convert.ToUInt32(numericSegitigaIn.Value);
                    string hsl = "";
                    for (uint i = input; i > 0; i--)
                    {
                        for (uint j = 0; j < i; j++)
                        {
                            hsl += " ";
                        }
                        for (uint k = input; k >= i; k--)
                        {
                            hsl += k;
                        }
                        hsl += "\n";
                    }
                    txtSegitigaOut.Text = hsl;
                }
                else txtSegitigaOut.Text = "";
            }
            catch
            {
                txtUbahOut.Text = "Invalid Input";
            }
        }

        bool isPrima(uint angka)
        {
            byte count = 0;
            for (int i = 2; i <= angka / 2; i++)
            {
                if (angka % i == 0) count++;
            }
            if (count > 0) return false;
            else return true;
        }

        string ubah(UInt64 input)
        {
            string hsl = "", t = input.ToString();
            t = t.PadLeft(t.Length + ((3 - (t.Length % 3)) % 3), '0');
            byte count = (byte)t.Length;
            for (int i = 0; i < t.Length; )
            {
                for (int j = 0; j < 3; j++)
                {
                    byte b = Convert.ToByte(t.Substring(i + j, 1));
                    if (b != 0)
                    {
                        if (j == 0)
                        {
                            if (b == 1) hsl += "se";
                            else hsl += (toKalimat)b + " ";
                            hsl += "ratus ";
                        }
                        else if (j == 1)
                        {
                            byte b2 = Convert.ToByte(t.Substring(i + j + 1, 1));
                            if (b == 1)
                            {
                                if (b2 == 0) hsl += "sepuluh ";
                                else if (b2 == 1) hsl += "sebelas ";
                                else hsl += (toKalimat)b2 + " belas ";
                                j += 1;
                            }
                            else hsl += (toKalimat)b + " puluh ";

                        }
                        else if (j == 2)
                        {
                            if (count > 3 && count < 7)
                            {
                                Int16 b3 = Convert.ToInt16(t.Substring(t.Length - count, 3));
                                if (b3 == 1) hsl += "se";
                                else hsl += (toKalimat)b + " ";
                            }
                            else hsl += (toKalimat)b + " ";
                        }
                    }
                }
                Int16 b4 = Convert.ToInt16(t.Substring(i, 3));
                if (b4 != 0)
                {
                    if (count > 15) hsl += "bilyun ";
                    else if (count > 12) hsl += "trilyun ";
                    else if (count > 9) hsl += "milyar ";
                    else if (count > 6) hsl += "juta ";
                    else if (count > 3) hsl += "ribu ";
                }
                count -= 3;
                i += 3;
            }
            return hsl;
        }
    }
}

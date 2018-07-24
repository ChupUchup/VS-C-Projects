using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Data.OleDb;

namespace MyHarvestmoon
{
    public partial class form_data : Form
    {
        //[DllImport("user32.dll")]
        //private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        public form_data()
        {
            InitializeComponent();
            //SendMessage(txt_name.Handle, 0x1501, 1, "Name");
            //SendMessage(txt_loves.Handle, 0x1501, 1, "Loves.");
            //SendMessage(txt_likes.Handle, 0x1501, 1, "Likes");
            //SendMessage(txt_neutral.Handle, 0x1501, 1, "Neutral");
            //SendMessage(txt_dislikes.Handle, 0x1501, 1, "Dislikes");
            //SendMessage(txt_hates.Handle, 0x1501, 1, "Hates");
        }
        //OleDbConnection conn = new OleDbConnection(Program.str_con);

        private void form_data_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Program.dataname)) File.CreateText(Program.dataname);
            else
            {
                if (txt_name.Text != null)
                {
                    //string input_str =
                    //    get_str(txt_name) + "|" +
                    //    get_str(txt_loves) + "|" +
                    //    get_str(txt_likes) + "|" +
                    //    get_str(txt_neutral) + "|" +
                    //    get_str(txt_dislikes) + "|" +
                    //    get_str(txt_hates);
                    //StreamWriter sw = new StreamWriter(Program.dataname);
                    //sw.WriteLine(input_str);
                    //sw.Dispose();

                    try
                    {
                        OleDbCommand cmd = Program.global_conn.CreateCommand();
                        cmd.CommandText = @"Insert into tbl_character values('" +
                            get_str(txt_name) + "','" +
                            get_str(txt_loves) + "','" +
                            get_str(txt_likes) + "','" +
                            get_str(txt_neutral) + "','" +
                            get_str(txt_dislikes) + "','" +
                            get_str(txt_hates) + "')";
                        cmd.Connection = Program.global_conn;
                        Program.global_conn.Open();
                        cmd.ExecuteNonQuery();
                        Program.global_conn.Close();
                        MessageBox.Show("Input Data Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK);
                    }
                }
                else MessageBox.Show("Please Input Name", "Info", MessageBoxButtons.OK);
            }
        }
        private string get_str(Control ctrl)
        {
            string tmp1 = ctrl.Text;
            tmp1.Trim('\n', ' ');
            string[] tmp2 = tmp1.Split(',');
            for (int i = 0; i < tmp2.Length; i++) tmp2[i] = tmp2[i].Trim('\n',' ');
            return string.Join(",", tmp2);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_name.Clear(); txt_loves.Clear(); txt_likes.Clear(); txt_neutral.Clear(); txt_dislikes.Clear(); txt_hates.Clear();
        }


    }
}

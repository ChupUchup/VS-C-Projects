using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyHarvestmoon
{
    static class Program
    {
        public static string dataname = "HM_BTN_data.txt";
        public static string str_con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=HMdata.mdb";
        public static OleDbConnection global_conn = new OleDbConnection(str_con);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyHarvestmoonApp());
        }
    }
}

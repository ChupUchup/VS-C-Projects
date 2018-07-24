using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace aodb.Resources
{
    public class mySQLITE
    {
        private SQLiteConnection _conn;
        private string _connString;
        public string ConnString { get { return this._connString; } set { this._connString = value; } }

        public mySQLITE() { }

        public mySQLITE(string connString)
        {
            this._connString = connString;
            _conn = new SQLiteConnection(connString);
        }

        public DataSet get_dataset(string query, SQLiteConnection conn)
        {
            DataSet hsl = new DataSet();
            using (var da = new SQLiteDataAdapter(query, conn))
            {
                conn.Open();
                da.Fill(hsl);
                conn.Close();
            }
            return hsl;
        }

        public DataSet get_dataset(string query)
        {
            return get_dataset(query, _conn);
        }

        public object get_datacell(string query, SQLiteConnection conn)
        {
            object hsl = null;
            using (var cmd = new SQLiteCommand(query, conn))
            {
                conn.Open();
                hsl = cmd.ExecuteScalar();
                conn.Close();
            }
            return hsl;
        }

        public object get_datacell(string query)
        {
            return get_datacell(query, _conn);
        }

        public int insert_data(string query, SQLiteConnection conn)
        {
            return execute_nonquery(query, conn);
        }

        public int insert_data(string query)
        {
            return insert_data(query, _conn);
        }

        private int execute_nonquery(string query, SQLiteConnection conn)
        {
            int hsl = 0;
            using (var cmd = new SQLiteCommand(query, conn))
            {
                conn.Open();
                hsl = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return hsl;
        }
    }
}

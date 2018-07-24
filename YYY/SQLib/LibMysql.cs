//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;

namespace SQLib
{
    public class LibMysql
    {
        private bool _IsConnect = false;
        public bool IsConnect { get { return _IsConnect; } }
        private string _ConnString = "";
        public string ConnString { get { return _ConnString; } set { _ConnString = value; } }
        private MySqlConnection _Conn;
        public LibMysql(string connString)
        {
            this._ConnString = connString;
            _Conn = new MySqlConnection(_ConnString);
            try { _Conn.Open(); _IsConnect = true; }
            catch (MySqlException ex) { _IsConnect = false; throw ex; }
            finally { _Conn.Close(); }
        }
        //public void CreateDb(string dbName) { SQLiteConnection.CreateFile(dbName); }
        public DataSet Select(string query)
        {
            DataSet hsl = new DataSet();
            using (var da = new MySqlDataAdapter(query, _Conn))
            {
                _Conn.Open();
                da.Fill(hsl);
                _Conn.Close();
            }
            return hsl;
        }
        public object SelectCell(string query)
        {
            object hsl = null;
            using (var cmd = new MySqlCommand(query, _Conn))
            {
                _Conn.Open();
                hsl = cmd.ExecuteScalar();
                _Conn.Close();
            }
            return hsl;
        }
        public int Insert(string query) { return ExecuteNonQuery(query); }
        public int Update(string query) { return ExecuteNonQuery(query); }
        public int Delete(string query) { return ExecuteNonQuery(query); }
        public int ExecuteNonQuery(string query)
        {
            int hsl = 0;
            using (var cmd = new MySqlCommand(query, _Conn))
            {
                _Conn.Open();
                hsl = cmd.ExecuteNonQuery();
                _Conn.Close();
            }
            return hsl;
        }
    }
}

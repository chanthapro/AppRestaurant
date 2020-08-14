using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AppResturant
{
    class AppConfig
    {
        #region ConfigConnectionString
        private string server { get { return "localhost"; } }
        private string port { get { return "3309"; } }
        private string db { get { return "dbr"; } }
        private string uid { get { return "root"; } }
        private string pass { get { return "root"; } }

        #endregion

        #region ConfigConnection
        public static MySqlConnection ConDB { get; set; }
        public MySqlCommand cmd { get; set; }
        public MySqlDataReader rd { get; set; }
        public MySqlDataAdapter adt { get; set; }
        public void DataCon()
        {
            ConDB = new MySqlConnection("server=" + server + ";port=" + port + ";database="+db+";uid=" + uid + ";password=" + pass + "");
            ConDB.Open();
        }
        #endregion

        #region User
        public  static string uname { get; set; }
        public static int usid { get; set; }
        #endregion

        #region MethodSQL
        public void exc(string s)
        {
            cmd = new MySqlCommand(s, ConDB);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        public int getLastID()
        {
            string s = "SELECT LAST_INSERT_ID()";
            cmd = new MySqlCommand(s, ConDB);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                int lastid = int.Parse(rd.GetValue(0) + "");
                rd.Close();
                cmd.Dispose();
                return lastid;
            }
            else
                rd.Close();
                cmd.Dispose();
                return 0;

            
        }
        public void start()
        {
            string s = "START TRANSACTION";
            exc(s);
        }
        public void rollback()
        {
            string s = "ROLLBACK";
            exc(s);

        }
        public void commit()
        {
            string s = "COMMIT";
            exc(s);
        }
        public void getDgv(DataGridView dgv, string query)
        {
            adt = new MySqlDataAdapter(query, ConDB);
            DataTable table = new DataTable();
            adt.Fill(table);
            dgv.DataSource = table;
            adt.Dispose();
        }
        public void getItemCombox(ComboBox cb,string query)
        {
            cb.Items.Clear();
            cmd = new MySqlCommand(query, ConDB);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cb.Items.Add(rd.GetValue(0) + "");
            }
            rd.Close();
            cmd.Dispose();
        }
        public double getPrice(string query)
        {
            cmd = new MySqlCommand(query, ConDB);
            rd = cmd.ExecuteReader();
            double price = 0;
            if (rd.Read())
            {
                price = double.Parse(rd.GetValue(0) + "");
            }
            rd.Close();
            cmd.Dispose();
            return price;
        }
        public bool getLogin(string user,string pass)
        {
            string q = "SELECT uid,uname,pass FROM tbuser WHERE uname='" + user + "' AND pass='" + pass + "'";
            cmd = new MySqlCommand(q, ConDB);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                usid = int.Parse(rd.GetValue(0) + "");
                uname = rd.GetValue(1) + "";
                rd.Close();
                cmd.Dispose();
                return true;
            }
            rd.Close();
            cmd.Dispose();
            return false;
        }
        #endregion

    }
}

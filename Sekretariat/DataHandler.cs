using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sekretariat
{
    internal class DataHandler
    {
        MySqlConnection conn;
        static string host = "localhost";
        static string db = "kolejka";
        static string userDB = "root";
        public static string provider = 
            "server=" + host + 
            ";Database=" + db + 
            ";User ID=" + userDB + 
            ";SSL Mode=None;Convert Zero Datetime=True;";

        public bool Open()
        {
            try
            {
                provider = 
                    "server=" + host + 
                    ";Database=" + db + 
                    ";User ID=" + userDB + 
                    ";SSL Mode=None;Convert Zero Datetime=True;";

                conn = new MySqlConnection(provider);
                conn.Open();

                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("connect1ection Error ! " + er.Message, "Information");
            }

            return false;
        }

        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }

        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);

                da.Fill(ds, "result");

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                MySqlTransaction mytransaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                int affected;

                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();

                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return -1;
        }
    }
}

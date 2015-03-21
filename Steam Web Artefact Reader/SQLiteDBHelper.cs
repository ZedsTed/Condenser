using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Condenser
{
    class SQLiteDBHelper
    {
        String dbConnection;


        public SQLiteDBHelper(String inputFile)
        {
            dbConnection = String.Format("Data Source={0}", inputFile);
        }


        public SQLiteDBHelper(Dictionary<String, String> connectionOpts)
        {
            String str = "";
            foreach (KeyValuePair<String, String> row in connectionOpts)
            {
                str += String.Format("{0}={1}; ", row.Key, row.Value);
            }
            str = str.Trim().Substring(0, str.Length - 1);
            dbConnection = str;
        }


        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteConnection cnn = new SQLiteConnection(dbConnection);
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                cnn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }               



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Condenser
{
    class SQLiteReader
    {
        public DataTable DBout;
        public SQLiteDBHelper DBsession;
        public string dbpath;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SQLiteReader(string path)
        {
            dbpath = path;
        }

        public DataTable GetConnection()
        {
            DBsession = new SQLiteDBHelper(dbpath);

            DBout = DBsession.GetDataTable("SELECT * FROM cookies");

            return DBout;
        }
    }    
}

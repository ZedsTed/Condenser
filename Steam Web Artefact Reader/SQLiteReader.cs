using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Steam_Web_Artefact_Reader
{
    class SQLiteReader
    {
        public DataTable DBout;
        public SQLiteDBHelper DBsession;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SQLiteReader()
        {
            
        }

        public DataTable GetConnection()
        {
            DBsession = new SQLiteDBHelper(@"C:\Program Files (x86)\Steam\config\htmlcache\Cookies;");

            DBout = DBsession.GetDataTable("SELECT * FROM cookies");

            return DBout;
        }
    }    
}

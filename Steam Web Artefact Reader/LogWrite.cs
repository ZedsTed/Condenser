using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics;

namespace Condenser
{
    public class LogWrite
    {
        public static string fullpath;
        public LogWrite(string path, string name)
        {
            fullpath = Path.Combine(path, name);
            CreateFile(path, fullpath);
        }

        public void CreateFile(string path, string fullpath)
        {           
            FileStream fs = null;
            
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);               
            }
            using (fs = File.Create(fullpath)) { }  
        }

        public void ClearLog(string fullpath)
        { 
            
        }

        public static void WriteLine(string line)
        {

            if (File.Exists(fullpath))
            {
                using (StreamWriter w = new StreamWriter(fullpath, true))
                {
                    w.WriteLineAsync(DateTime.Now.ToString("HH:mm:ss.fff", CultureInfo.InvariantCulture) + ": " + line);
                }
            }
        }

        public static void WriteLineNoDate(string line)
        {

            if (File.Exists(fullpath))
            {
                using (StreamWriter w = new StreamWriter(fullpath, true))
                {
                    w.WriteLineAsync(line);
                }
            }
        }
    }
}

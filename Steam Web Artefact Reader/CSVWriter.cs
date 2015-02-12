using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condenser
{
    //Written using the following resource as a reference: http://www.codeproject.com/Articles/415732/Reading-and-Writing-CSV-Files-in-Csharp
    class CSVWriter
    {
        List<string[]> data = new List<string[]>();
        string path;
        string csvname;
        public CSVWriter(List<string[]> _data, string _path, string name)
        {
            data = _data;
            path = _path;
            csvname = name + ".csv";
        }

        public void Write()
        {
            //filedata array info:
            //0: name
            //1: path
            //2: size
            //3: accessdate
            //4: creationdate
            //5: modificationdate
            //6: md5hash
            //7: sha1hash 
            string fullpath = path + csvname;
            string headers = "Name,Path,Size (bytes),Access Date,Creation Date,Modification Date,MD5 Hash,SHA1 Hash";

            StreamWriter stream = new StreamWriter(fullpath, true);
            for (int i = 0; i < data.Count; i++)
            {
                if (i == 0)
                {
                    Debug.WriteLine("Written headers.");
                    stream.WriteLine(headers);
                }
                Debug.WriteLine("Writing row for file: " + i);
                WriteRow(data[i], stream);
            }
            stream.Close();
        }

        public void WriteRow(string[] line, StreamWriter write)
        {
            bool firstColumn = true;
            StringBuilder sb = new StringBuilder();

            Debug.WriteLine("Row being written..");
            for (int j = 0; j < line.Length; j++)
            {
                if (!firstColumn)
                {
                    sb.Append(",");
                }

                if (line[j].IndexOfAny(new char[] { '"', ',' }) != -1)
                {
                    sb.AppendFormat("\"{0}\"", line[j].Replace("\"", "\"\""));
                }
                else { sb.Append(line[j]);}
                firstColumn = false;
            }
            write.WriteLine(sb.ToString());
        }
    }
}

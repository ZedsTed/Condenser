using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Steam_Web_Artefact_Reader
{
    class FileCarver : FileOperations
    {

        public FileCarver()
        { }

        public byte[] GetBytes(string filepath)
        {
            byte[] data;

            if (!File.Exists(filepath))
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + filepath);
            }

            //FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);

            try
            {
                data = File.ReadAllBytes(filepath);
                //fs.Read(data, 0, data.Length);
            }
            catch
            {
                throw new FileLoadException("Couldn't load: " + filepath);
                //return null;
            }
            finally
            {
                //fs.Close();
            }


            return data;
        }

        public byte[] Carve(byte[] data)
        {
            int offset = 0;
            byte[] file = new byte[data.Length];

            // We want to convert the byte array to a hex-formatted string.
            StringBuilder sBuilder = new StringBuilder();
            
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            string datastring = Convert.ToString(sBuilder);
            //Now we scan the string for the hex code we want.
            Debug.WriteLine(datastring);
            Match match = Regex.Match(datastring, @"ffd8ffe00010", RegexOptions.IgnoreCase & RegexOptions.Singleline);
            if (match.Success)
            {
                offset = (match.Index/2); //We need to divide it by two as hex is two chars and regex is checking them one at a time.
                Debug.WriteLine("Found JPG at: " + offset);
                int j = 0;
                for (int i = offset; i < data.Length; i++)
                {
                    file[j] = data[i];
                    j++;
                    Debug.WriteLine("Copying to new byte array...");
                }
                Create(file);
            }
            else { Debug.WriteLine("Found no media data!"); }


            return file;
        }


        public void Create(byte[] file)
        {
            File.WriteAllBytes(@"C:\Condenser\Data_Carve_Results\file.jpg", file);
            Debug.WriteLine("Created file!");
        }
    }
}

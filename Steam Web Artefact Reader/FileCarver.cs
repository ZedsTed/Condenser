using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Condenser
{
    public class FileCarver
    {
        string[] files;
        string[] startHexCodes = SetupStartHexCodes();
        string[] endHexCodes = SetupEndHexCodes();
        public static string name = "file";
        public string path;
        
        public int index = 0;
       
        public FileCarver()
        {
            
        }

        public FileCarver(string[] _files, string _path)
        {
            files = _files;
            path = _path;
        }

        private static string[] SetupStartHexCodes()
        {
            //string array of length 9.
            //6 types
            string[] _startHexCodes = 
            {
                "474946383761",                  //GIF
                "474946383961",                  //GIF
                "ffd8ffe00010",                  //JPG
                "ffd8ffee00",                    //JPG
                "ffd8ffe1",                      //JPG
                "ffd8fffe",                      //JPG
                "464c5601",                      //FLV
                "89504e47",                      //PNG
                "3c21444f43545950452068746d6c3e" //HTML
            };
            return _startHexCodes;
        }

        private static string[] SetupEndHexCodes()
        {
            //string array of length 5
            //5 types
            string[] _endHexCodes = 
            {
                "003b",                  //GIF
                "ffd9",                  //JPG
                "01ae090000050129",      //FLV
                "fffcfdfe",              //PNG
                "3c2f68746d6c3e"         //HTML   
            };

            return _endHexCodes;
        }

        public void CarveManager()
        {
            LogWrite.WriteLine("File Carver: Started Carve Manager.");
            int total = files.Length;
            for (int i = 0; i < total; i++)
            {
                LogWrite.WriteLine("File Carver: Carving file " + files[i].ToString() + ". " + i + " of " + total + " files.");
                byte[] filebytes = GetBytes(files[i]);
                Carve(filebytes, files[i], i);
            }
            LogWrite.WriteLine("File Carver: Finished File Carving.\n");
            MessageBox.Show("Finished file carving! Attempted carving on " + total + " files." );
        }

        public byte[] GetBytes(string filepath)
        {
            byte[] data;

            if (!File.Exists(filepath))
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + filepath);
            }

            

            try
            {
                data = File.ReadAllBytes(filepath);                
            }
            catch
            {
                throw new FileLoadException("Couldn't load: " + filepath);                
            }

            return data;
        }



        public void Carve(byte[] data, string filepath, int findex)
        {
            
            int endvalue = 0;
            int offset = 0;
            byte[] file = new byte[data.Length + 1];

            // We want to convert the byte array to a hex-formatted string.
            
            StringBuilder sBuilder = new StringBuilder();
            
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            string datastring = Convert.ToString(sBuilder);
            //Now we scan the string for the hex code we want.

            for (int i = 0; i < startHexCodes.Length; i++)
            {
                Match match = Regex.Match(datastring, startHexCodes[i], RegexOptions.IgnoreCase & RegexOptions.Singleline);
                if (match.Success)
                {
                    LogWrite.WriteLine("File Carver: Found start hex pattern for file. Type: " + startHexCodes[i]);
                    offset = (match.Index / 2); //We need to divide it by two as hex is two chars and regex is checking them one at a time.
                                        
                    if (offset > 0)
                    {
                        string endHexCode = "00";
                        if (i == 0 || i == 1)//GIF
                        {
                            endHexCode = "003b";
                        }

                        else if (i == 2 || i == 3 || i == 4 || i == 5)//JPG
                        {
                            endHexCode = "fffd9";
                        }

                        else if (i == 6)//FLV
                        {
                            endHexCode = "01ae090000050129";
                        }

                        else if (i == 7)//PNG
                        {
                            endHexCode = "fffcfdfe";
                        }

                        else if (i == 8)//HTML
                        {
                            endHexCode = "3c2f68746d6c3e";
                        }

                        Match endmatch = Regex.Match(datastring, endHexCode, RegexOptions.IgnoreCase & RegexOptions.Singleline);
                        if (endmatch.Success)
                        {

                            LogWrite.WriteLine("File Carver: Found end hex pattern for file. Type: " + endHexCode);
                            endvalue = (endmatch.Index / 2);
                            if (endvalue > offset) //Ensures that we're only carving positive matches, where the endvalue is after the start.
                            {
                                int copysize = endvalue - offset;
                                Array.Copy(data, offset, file, 0, copysize);
                                LogWrite.WriteLine("File Carver: Carving with offset, and endvalue at " + endvalue.ToString() + " offset.");
                            }
                        }
                        if (!endmatch.Success)//If no hex code matches for the file type.
                        {
                            int copysize = data.Length - offset;
                            Array.Copy(data, offset, file, 0, copysize);
                            LogWrite.WriteLine("File Carver: Found no end hex code that matches. Carving the file from the offset to the end.");
                        }

                        for (int j = 0; j < endHexCodes.Length; j++ )
                        {
                            

                        }
                    }
                    else { file = data; }
                    switch (i)
                    { 
                        case 0:
                            GIF(file, findex, i);
                            break;
                        case 1:
                            GIF(file, findex, i);
                            break;
                        case 2:
                            JPG(file, findex, i);
                            break;
                        case 3:
                            JPG(file, findex, i);
                            break;
                        case 4:
                            JPG(file, findex, i);
                            break;
                        case 5:
                            JPG(file, findex, i);
                            break;
                        case 6:
                            FLV(file, findex, i);
                            break;
                        case 7:
                            PNG(file, findex, i);
                            break;
                        case 8:
                            HTML(file, findex, i);
                            break;
                    }
                    /*if (endvalue == 0)
                    {
                        break;
                    }*/
                }
                if (i == startHexCodes.Length)
                {
                    LogWrite.WriteLine("File Carver: Found no hex codes that match for file: " + filepath + "\n");
                }
            }
        }




        public void JPG(byte[] file, int findex, int i)
        {
            string fpath = Path.Combine(path, @"jpg\");
            string type = ".jpg";
            DirectoryInfo dir = new DirectoryInfo(fpath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(fpath);
            }
            if (File.Exists(fpath + name + findex + "-" + i + type))
            {
                File.Delete(fpath + name + findex + "-" + i + type);                
            }

            File.WriteAllBytes(fpath + name + findex + "-" + i + type, file);
            LogWrite.WriteLine("File Carver: Created JPG:\n" + fpath + name + findex + "-" + i + type + "\n\n");
        }

        public void GIF(byte[] file, int findex, int i)
        {
            string fpath = Path.Combine(path, @"gif\");
            string type = ".gif";
            DirectoryInfo dir = new DirectoryInfo(fpath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(fpath);
            }
            if (File.Exists(fpath + name + findex + "-" + i + type))
            {
                File.Delete(fpath + name + findex + "-" + i + type);
            }

            File.WriteAllBytes(fpath + name + findex + "-" + i + type, file);
            LogWrite.WriteLine("File Carver: Created GIF:\n" + fpath + name + findex + "-" + i + type + "\n\n");
        }
        public void PNG(byte[] file, int findex, int i)
        {
            string fpath = Path.Combine(path, @"png\");
            string type = ".png";
            DirectoryInfo dir = new DirectoryInfo(fpath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(fpath);
            }
            if (File.Exists(fpath + name + findex + "-" + i + type))
            {
                File.Delete(fpath + name + findex + "-" + i + type);
            }

            File.WriteAllBytes(fpath + name + findex + "-" + i + type, file);
            LogWrite.WriteLine("File Carver: Created PNG:\n" + fpath + name + findex + "-" + i + type + "\n\n");
        }
        public void FLV(byte[] file, int findex, int i)
        {
            string fpath = Path.Combine(path, @"flv\");
            string type = ".flv";
            DirectoryInfo dir = new DirectoryInfo(fpath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(fpath);
            }
            if (File.Exists(fpath + name + findex + "-" + i + type))
            {
                File.Delete(fpath + name + findex + "-" + i + type);
            }

            File.WriteAllBytes(fpath + name + findex + "-" + i + type, file);
            LogWrite.WriteLine("File Carver: Created FLV:\n" + fpath + name + findex + "-" + i + type + "\n\n");
        }
        public void HTML(byte[] file, int findex, int i)
        {
            string fpath = Path.Combine(path, @"html\");
            string type = ".html";
            DirectoryInfo dir = new DirectoryInfo(fpath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(fpath);
            }
            if (File.Exists(fpath + name + findex + "-" + i + type))
            {
                File.Delete(fpath + name + findex + "-" + i + type);
            }
            File.WriteAllBytes(fpath + name + findex + "-" + i + type, file);
            LogWrite.WriteLine("File Carver: Created HTML:\n" + fpath + name + findex + "-" + i + type + "\n\n");
        }

    }
}

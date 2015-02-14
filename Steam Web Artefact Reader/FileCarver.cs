using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Condenser
{
    public class FileCarver
    {
        
        string[] startHexCodes = SetupStartHexCodes();

        //Dictionary<string, string> endHexCodes = new Dictionary<string, string>();

        public FileCarver()
        {
            
        }

        private static string[] SetupStartHexCodes()
        {
            //string array of length 10.
            //5 types
            string[] _startHexCodes = 
            {
                "474946383761",//GIF
                "474946383961",//GIF
                "ffd8ffe00010",//JPG
                "ffd8ffe1",    //JPG
                "ffd8fffe",    //JPG
                "464c5601",      //FLV
                "89504e47",    //PNG
                "424df8a9",    //BMP
                "424d6225",    //BMP
                "424d7603"     //BMP
            };
            return _startHexCodes;
        }

        /*private Dictionary<string, string> SetupEndHexCodes()
        {
            Dictionary<string, string> _endHexCodes = new Dictionary<string, string>();

            _endHexCodes.Add("gif1", "003b");
            _endHexCodes.Add("gif2", "00003b");
            _endHexCodes.Add("jpg1", "ffd9");
            _endHexCodes.Add("jpg2", "ffd9");
            _endHexCodes.Add("", "");
            _endHexCodes.Add("", "");
            _endHexCodes.Add("", "");

            return _endHexCodes;
        }*/

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

        public void Carve(byte[] data)
        {
            

            
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
            //Debug.WriteLine(datastring);
            for (int i = 0; i < startHexCodes.Length; i++)
            {
                Match match = Regex.Match(datastring, startHexCodes[i], RegexOptions.IgnoreCase & RegexOptions.Singleline);
                if (match.Success)
                {
                    Debug.WriteLine("Match success!");
                    offset = (match.Index / 2); //We need to divide it by two as hex is two chars and regex is checking them one at a time.
                    Debug.WriteLine(offset);
                    int k = 0;
                    if (offset > 0)
                    {
                        int copysize = data.Length - offset;
                        Array.Copy(data, offset, file, 0, copysize);
                        //file.CopyTo(data, offset);
                        Debug.WriteLine("Copying to new array. With offset.");
                        /*for (int j = offset; j < data.Length; j++)
                        {
                            file[k] = data[j];
                            k++;
                            Debug.WriteLine("Copying to to new array. On byte" + j + " of " + data.Length + " bytes.");
                        }*/
                    }
                    else { file = data; Debug.WriteLine("Created new byte array from 0 offset."); }
                    switch (i)
                    { 
                        case 0:
                            GIF(file);
                            break;
                        case 1:
                            GIF(file);
                            break;
                        case 2:
                            JPG(file);
                            break;
                        case 3:
                            JPG(file);
                            break;
                        case 4:
                            JPG(file);
                            break;
                        case 5:
                            FLV(file);
                            break;
                        case 6:
                            PNG(file);
                            break;
                        case 7:
                            BMP(file);
                            break;
                        case 8:
                            BMP(file);
                            break;
                        case 9:
                            BMP(file);
                            break;
                    }
                    break;
                    //Debug.WriteLine("Found JPG at: " + offset);

                    //Create(file);
                }
                else { Debug.WriteLine("Found no media data!"); }
            }


            //return file;
        }

       


        public void JPG(byte[] file)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Condenser\Data_Carve_Results\JPGs\");
            if (!dir.Exists)
            {
                Directory.CreateDirectory(@"C:\Condenser\Data_Carve_Results\JPGs\");
            }
            if (File.Exists(@"C:\Condenser\Data_Carve_Results\JPGs\file.jpg"))
            {
                File.Delete(@"C:\Condenser\Data_Carve_Results\JPGs\file.jpg");
                Debug.WriteLine("Deleted JPG!");
            }
            
            File.WriteAllBytes(@"C:\Condenser\Data_Carve_Results\JPGs\file.jpg", file);
            Debug.WriteLine("Created JPG!");
        }

        public void GIF(byte[] file)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Condenser\Data_Carve_Results\JPGs\");
            if (!dir.Exists)
            {
                Directory.CreateDirectory(@"C:\Condenser\Data_Carve_Results\GIFs\");
            }
            if (File.Exists(@"C:\Condenser\Data_Carve_Results\JPGs\file.gif"))
            {
                File.Delete(@"C:\Condenser\Data_Carve_Results\JPGs\file.gif");
            }

            File.WriteAllBytes(@"C:\Condenser\Data_Carve_Results\GIFs\file.gif", file);
            Debug.WriteLine("Created GIF!");
        }
        public void PNG(byte[] file)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Condenser\Data_Carve_Results\JPGs\");
            if (!dir.Exists)
            {
                Directory.CreateDirectory(@"C:\Condenser\Data_Carve_Results\PNGs\");
            }
            if (File.Exists(@"C:\Condenser\Data_Carve_Results\JPGs\file.png"))
            {
                File.Delete(@"C:\Condenser\Data_Carve_Results\JPGs\file.png");
            }

            File.WriteAllBytes(@"C:\Condenser\Data_Carve_Results\PNGs\file.png", file);
            Debug.WriteLine("Created PNG!");
        }
        public void FLV(byte[] file)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Condenser\Data_Carve_Results\JPGs\");
            if (!dir.Exists)
            {
                Directory.CreateDirectory(@"C:\Condenser\Data_Carve_Results\FLVs\");
            }
            if (File.Exists(@"C:\Condenser\Data_Carve_Results\JPGs\file.flv"))
            {
                File.Delete(@"C:\Condenser\Data_Carve_Results\JPGs\file.flv");
            }

            File.WriteAllBytes(@"C:\Condenser\Data_Carve_Results\FLVs\file.flv", file);
            Debug.WriteLine("Created FLV!");
        }
        public void BMP(byte[] file)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Condenser\Data_Carve_Results\JPGs\");
            if (!dir.Exists)
            {
                Directory.CreateDirectory(@"C:\Condenser\Data_Carve_Results\BMPs\");
            }
            if (File.Exists(@"C:\Condenser\Data_Carve_Results\JPGs\file.bmp"))
            {
                File.Delete(@"C:\Condenser\Data_Carve_Results\JPGs\file.bmp");
            }
            File.WriteAllBytes(@"C:\Condenser\Data_Carve_Results\BMPs\file.bmp", file);
            Debug.WriteLine("Created BMP!");
        }

    }
}

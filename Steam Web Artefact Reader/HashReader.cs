using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Web_Artefact_Reader
{
    class HashReader
    {
        string filePath, md5HashString, sha1HashString;
        bool md5, sha1 = false;
        byte[] md5hash, sha1hash;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newFilePath"></param>
        public HashReader(string newFilePath)
        {
            filePath = newFilePath;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newFilePath"></param>
        /// <param name="usemd5"></param>
        /// <param name="usesha1"></param>
        public HashReader(string newFilePath, bool usemd5, bool usesha1)
        {
            filePath = newFilePath;
            md5 = usemd5;
            sha1 = usesha1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetMD5Hash()
        {
            // Create a DirectoryInfo object representing the specified directory.
            DirectoryInfo dir = new DirectoryInfo(filePath);
            // Get the FileInfo objects for every file in the directory.
            FileInfo[] files = dir.GetFiles();

            MD5 md5HashObj = MD5.Create();
            
            foreach (FileInfo fInfo in files)
            {
                // Create a fileStream for the file.
                FileStream fileStream = fInfo.Open(FileMode.Open);
                // Be sure it's positioned to the beginning of the stream.
                fileStream.Position = 0;
                // Compute the hash of the fileStream.
                md5hash = md5HashObj.ComputeHash(fileStream);
                StringBuilder sBuilder = new StringBuilder();
                // Loop through each byte of the hashed data  
                // and format each one as a hexadecimal string. 
                for (int i = 0; i < md5hash.Length; i++)
                {
                    sBuilder.Append(md5hash[i].ToString("x2"));
                }

                md5HashString = Convert.ToString(sBuilder);
                
                // Close the file.
                fileStream.Close();
            }

            return md5HashString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetSHA1Hash()
        {
            // Create a DirectoryInfo object representing the specified directory.
            DirectoryInfo dir = new DirectoryInfo(filePath);
            // Get the FileInfo objects for every file in the directory.
            FileInfo[] files = dir.GetFiles();

            SHA1 sha1HashObj = SHA1.Create();
            //byte[] md5hash;

            foreach (FileInfo fInfo in files)
            {
                // Create a fileStream for the file.
                FileStream fileStream = fInfo.Open(FileMode.Open);
                // Be sure it's positioned to the beginning of the stream.
                fileStream.Position = 0;
                // Compute the hash of the fileStream.
                sha1hash = sha1HashObj.ComputeHash(fileStream);

                StringBuilder sBuilder = new StringBuilder();
                // Loop through each byte of the hashed data  
                // and format each one as a hexadecimal string. 
                for (int i = 0; i < sha1hash.Length; i++)
                {
                    sBuilder.Append(sha1hash[i].ToString("x2"));
                }

                sha1HashString = Convert.ToString(sBuilder);
                // Close the file.
                fileStream.Close();
            }
            return sha1HashString;        
        }


    }
}

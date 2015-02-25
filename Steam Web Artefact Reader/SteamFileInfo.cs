using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Condenser
{
    class SteamFileInfo
    {
        string file;

        public SteamFileInfo()
        { }

        public SteamFileInfo(string file)
        {
            this.file = file;
        }

        public string GetFileName()
        {
            FileInfo fileinfo = new FileInfo(file);
            string filename = fileinfo.Name;

            return filename;
        }

        public string GetFilePath()
        {
            FileInfo fileinfo = new FileInfo(file);
            string filepath = fileinfo.DirectoryName;

            return filepath;
        }

        public string GetFileSize()
        {
            long size;
            FileInfo fileinfo = new FileInfo(file);
            size = fileinfo.Length;
            string fileSize = size.ToString();
            
            return fileSize;
        }

        public string GetCreationDate()
        {
            string creationDate;
            DateTime date = File.GetCreationTime(file);
            creationDate = date.ToString();

            return creationDate;
        }

        public string GetAccessDate()
        {
            string accessDate;
            DateTime date = File.GetLastAccessTime(file);
            accessDate = date.ToString();

            return accessDate;
        }

        public string GetModifiedDate()
        {
            string modifiedDate;
            DateTime date = File.GetLastWriteTime(file);
            modifiedDate = date.ToString();

            return modifiedDate;

        }

        public string GetMD5Hash()
        {
            //HashReader hashops = new HashReader();
            string md5 = HashOperations.MD5Hash(file);           

            return md5;
        }

        public string GetSHA1Hash()
        {
            //HashReader hashops = new HashReader(file);
            string sha1 = HashOperations.SHA1Hash(file);

            return sha1;
        }

    }
}

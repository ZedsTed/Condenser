using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condenser
{
    class CSVHelper
    {
        public List<string> filelist = new List<string>();
        public CSVHelper(List<string> files)
        {
            filelist = files;
        }

        public List<string[]> GetFileListData()
        {
            List<string[]> filesdata = new List<string[]>();

            for (int i = 0; i < filelist.Count; i++)
            {
                GetFileData(filelist[i]);
            }

            return filesdata;
        }

        public string[] GetFileData(string file)
        {
            SteamFileInfo FI = new SteamFileInfo(file);
            
            //filedata array info:
            //0: name
            //1: path
            //2: size
            //3: accessdate
            //4: creationdate
            //5: modificationdate
            //6: md5hash
            //7: sha1hash            
            string[] filedata = new string[8];
            filedata[0] = FI.GetFileName();
            filedata[1] = FI.GetFilePath();
            filedata[2] = FI.GetFileSize();
            filedata[3] = FI.GetAccessDate();
            filedata[4] = FI.GetCreationDate();
            filedata[5] = FI.GetModifiedDate();
            filedata[6] = FI.GetMD5Hash();
            filedata[7] = FI.GetSHA1Hash();



            return filedata;
        }
    }
}

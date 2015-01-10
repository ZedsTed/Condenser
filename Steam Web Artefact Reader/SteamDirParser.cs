using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Web_Artefact_Reader
{
    class SteamDirParser
    {
        private string steamDir;
        private string[] steamFilesConfig, steamFilesAppCache;
        public List<string> steamFilesList = new List<string>();
        private bool config, httpcache;

        /// <summary>
        /// Finds and sets the Steam installation directory, has the default directory set currently.
        /// </summary>
        /// <returns>A steam directory string.</returns>
        public string findSteamDir()
        {
             steamDir = @"C:\Program Files (x86)\Steam\";
             return steamDir;
        }

        /// <summary>
        /// Recursively gets an array of all the files in the config directory.
        /// </summary>
        /// <returns>A string array of the config directory's files.</returns>
        public List<string> listSteamFiles(bool config, bool httpcache)
        {
            if (config && httpcache)
            {
                steamFilesConfig = System.IO.Directory.GetFiles(steamDir + @"config\", "*", System.IO.SearchOption.AllDirectories);
                steamFilesAppCache = System.IO.Directory.GetFiles(steamDir + @"appcache\httpcache\", "*", System.IO.SearchOption.AllDirectories);

                int j = steamFilesConfig.Count();
                for (int i = 0; i < j; i++)
                {
                    steamFilesList.Add(steamFilesConfig[i]);
                }

                int k = steamFilesAppCache.Count();
                for (int i = 0; i < k; i++)
                {
                    steamFilesList.Add(steamFilesAppCache[i]);
                }
            }
            return steamFilesList;
        }
 
    }
}

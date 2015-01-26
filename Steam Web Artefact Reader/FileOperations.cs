using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Web_Artefact_Reader
{
    class FileOperations
    {

        public string directorySteam, directoryConfig, directoryAppCache, directoryCopy, subDirConfig, subDirAppCache;
        private string[] FilesConfig, FilesAppCache;
        public List<string> sourceAllFilesList = new List<string>();
        public List<string> sourceConfigFilesList = new List<string>();
        public List<string> sourceAppCacheFilesList = new List<string>();
        //private bool config, httpcache;

        public FileOperations()
        { }      

        

        /// <summary>
        /// Finds and sets the Steam installation directory, has the default directory set currently.
        /// </summary>
        /// <returns>A steam directory string.</returns>
        public string SteamDirectory()
        {     
            directorySteam = @"C:\Program Files (x86)\Steam\";
            return directorySteam;
        }
        /// <summary>
        /// Recursively gets an array of all the files in the config directory.
        /// </summary>
        /// <returns>A string array of the config directory's files.</returns>
        public List<string> GetAllFiles(string path)
        {
            directorySteam = path;
            subDirConfig = @"config\";
            subDirAppCache = @"appcache\httpcache\";

            directoryConfig = directorySteam + subDirConfig;
            directoryAppCache = directorySteam + subDirAppCache;

            // Grab files from directories.
            FilesConfig = Directory.GetFiles(directoryConfig, "*", System.IO.SearchOption.AllDirectories);
            FilesAppCache = Directory.GetFiles(directoryAppCache, "*", System.IO.SearchOption.AllDirectories);

            
            for (int i = 0; i < FilesConfig.Count(); i++)
            {
                sourceAllFilesList.Add(FilesConfig[i]);
            }
            
            for (int i = 0; i < FilesAppCache.Count(); i++)
            {
                sourceAllFilesList.Add(FilesAppCache[i]);
            }
            return sourceAllFilesList;
        }

        public List<string> GetConfigFiles(string path)
        {
            directorySteam = path;
            subDirConfig = @"config\";
            directoryConfig = directorySteam + subDirConfig;
            // Grab files from directories.
            FilesConfig = Directory.GetFiles(directoryConfig, "*", System.IO.SearchOption.AllDirectories);

            for (int i = 0; i < FilesConfig.Count(); i++)
            {
                sourceConfigFilesList.Add(FilesConfig[i]);
            }
            
            return sourceAllFilesList;
        }

        public List<string> GetAppCacheFiles(string path)
        {
            directorySteam = path;
            subDirAppCache = @"appcache\httpcache\"; 
            directoryAppCache = directorySteam + subDirAppCache;

            // Grab files from directories.
            FilesAppCache = Directory.GetFiles(directoryAppCache, "*", System.IO.SearchOption.AllDirectories);

            for (int i = 0; i < FilesAppCache.Count(); i++)
            {
                sourceAppCacheFilesList.Add(FilesAppCache[i]);
            }
            return sourceAppCacheFilesList;
        }

        public void FileCopy(string sourcepath, string destinationpath)
        {
            //Get config and appcache subdirs
            string configpath = @"config\";
            string appcachepath = @"appcache\httpcache\";

            List<string> configsubs = GetSubdirectories(sourcepath, configpath);
            List<string> appcachesubs = GetSubdirectories(sourcepath, appcachepath);

            //Copy config contents.
            string _destinationpath = Path.Combine(destinationpath, configpath);
            string _sourcepath = Path.Combine(sourcepath, configpath);
            Debug.WriteLine("Copying source config files...");
            DirectoryCopy(_sourcepath, _destinationpath);//copy main config folder contents.
            Debug.WriteLine("Finished copying source Config files...");
            _destinationpath = Path.Combine(destinationpath, appcachepath);
            _sourcepath = Path.Combine(sourcepath, appcachepath);
            Debug.WriteLine("Copying source appcache files...");
            DirectoryCopy(_sourcepath, _destinationpath);
            Debug.WriteLine("Finished copying source appcache files...");

            Debug.WriteLine("Generating and comparing hashses...");
            if (HashChecking(_sourcepath, _destinationpath))
            {
                Debug.WriteLine("Hash check success!");
            }
            else { Debug.WriteLine("Hash fail."); }            
        }

        public List<string> GetSubdirectories(string path, string subpath)
        {
            List<string> subdirs = new List<string>();

            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] _subdirs = dir.GetDirectories(subpath);

            for (int i = 0; i < _subdirs.Length; i++)
            {
                subdirs.Add(_subdirs[i].ToString());
            }
            return subdirs;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public void DirectoryCopy(string source, string destination)
        {
            DirectoryInfo sourcedir = new DirectoryInfo(source);
            DirectoryInfo destdir = new DirectoryInfo(destination);            

            if (!sourcedir.Exists)
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: "+ source);
            }

            foreach (string dirpath in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
            {
                Debug.WriteLine("Creating directory: " + dirpath);
                Directory.CreateDirectory(dirpath.Replace(source, destination));
            }

            foreach(string newpath in Directory.GetFiles(source, "*", SearchOption.AllDirectories))
            {
                Debug.WriteLine("Creating file: " + newpath);
                File.Copy(newpath, newpath.Replace(source, destination));
            }
        }

        public bool HashChecking(string source, string destination)
        { 
            bool hashsuccess = false;
            int d = 0;
            int l = 0;
            List<string> MD5source = new List<string>();
            List<string> SHA1source = new List<string>();

            List<string> MD5destination = new List<string>();
            List<string> SHA1destination = new List<string>();

            foreach(string path in Directory.GetFiles(source, "*", SearchOption.AllDirectories))
            {
                Debug.WriteLine("Generating MD5 Hash for: " + path);
                MD5source.Add(HashReader.MD5Hash(path));
                Debug.WriteLine("Generating SHA1 Hash for: " + path);
                SHA1source.Add(HashReader.SHA1Hash(path));
            }

            foreach(string path in Directory.GetFiles(destination, "*", SearchOption.AllDirectories))
            {
                Debug.WriteLine("Generating MD5 Hash for: " + path);
                MD5destination.Add(HashReader.MD5Hash(path));
                Debug.WriteLine("Generating SHA1 Hash for: " + path);
                SHA1destination.Add(HashReader.SHA1Hash(path));
            }

            for (int i = 0; i < MD5source.Count && i < MD5destination.Count; i++ )
            {
                
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                if (comparer.Compare(MD5source[i], MD5destination[i]) == 0)
                {
                    Debug.WriteLine("MD5 match!");
                }
                else { l++; }
            }

            for (int j = 0; j < SHA1source.Count && j < SHA1destination.Count; j++)
            {
                
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                if (comparer.Compare(SHA1source[j], SHA1destination[j]) == 0)
                {
                    Debug.WriteLine("SHA1 match!");
                }
                else { d++; }
            }

            if ((d == 0) && (l == 0))
            {
                hashsuccess = true;
            }

            return hashsuccess;
        }
    }
}

using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Steam_Web_Artefact_Reader
{
    class FileOperations
    {

        public string directorySteam, directoryConfig, directoryAppCache, directoryCopy, subDirConfig, subDirAppCache;
        public string sourcepath, destinationpath;
        public int listprogress, listtotal;
        private string[] FilesConfig, FilesAppCache;
        public List<string> sourceAllFilesList = new List<string>();
        public List<string> sourceDirsList = new List<string>();
        public List<string> sourceConfigFilesList = new List<string>();
        public List<string> sourceAppCacheFilesList = new List<string>();
        //private bool config, httpcache;

        public FileOperations()
        { 
        
        }

        public FileOperations(string _sourcepath, string _destinationpath)
        {
            sourcepath = _sourcepath;
            destinationpath = _destinationpath;
        }      

        

        /// <summary>
        /// Finds and sets the Steam installation directory, has the default directory set currently.
        /// </summary>
        /// <returns>A steam directory string.</returns>
        public string SteamDirectory()
        {
            directorySteam = @"C:\Condenser\Source\";
            return directorySteam;
        }
        /// <summary>
        /// Recursively gets an array of all the files in the config directory.
        /// </summary>
        /// <returns>A string array of the config directory's files.</returns>
        public List<string> GetAllFiles(string path)
        {
            subDirConfig = @"config\";
            subDirAppCache = @"appcache\httpcache\";

            directoryConfig = path + subDirConfig;
            directoryAppCache = path + subDirAppCache;

            // Grab files from directories.
            FilesConfig = Directory.GetFiles(directoryConfig, "*", System.IO.SearchOption.AllDirectories);
            FilesAppCache = Directory.GetFiles(directoryAppCache, "*", System.IO.SearchOption.AllDirectories);
            
            for (int i = 0; i < FilesConfig.Length; i++)
            {

                sourceAllFilesList.Add(FilesConfig[i]);
            }
            
            for (int i = 0; i < FilesAppCache.Length; i++)
            {
               
                sourceAllFilesList.Add(FilesAppCache[i]);
            }
            return sourceAllFilesList;
        }

        public List<string> GetAllDirectories(string path)
        {
            subDirConfig = @"config\";
            subDirAppCache = @"appcache\httpcache\";

            directoryConfig = path + subDirConfig;
            directoryAppCache = path + subDirAppCache;

            Debug.WriteLine("Config Directory: " + directoryConfig);
            Debug.WriteLine("AppCache Directory: " + directoryAppCache);

            // Grab files from directories.

            string[] configDir = Directory.GetDirectories(directoryConfig, "*", System.IO.SearchOption.AllDirectories);
            string[] appCacheDir = Directory.GetDirectories(directoryAppCache, "*", System.IO.SearchOption.AllDirectories);

            //listprogress = 0;
            //listtotal = (FilesConfig.Length + FilesAppCache.Length);

            for (int i = 0; i < configDir.Length; i++)
            {
                sourceDirsList.Add(configDir[i]);
            }

            for (int i = 0; i < appCacheDir.Length; i++)
            {

                sourceDirsList.Add(appCacheDir[i]);
            }
            Debug.WriteLine("Got directories...");
            return sourceDirsList;
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

        public void FileCopy()
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

            FullCopy(_sourcepath, _destinationpath);//copy main config folder contents.
            
            Debug.WriteLine("Finished copying source Config files...");

            _destinationpath = Path.Combine(destinationpath, appcachepath);
            _sourcepath = Path.Combine(sourcepath, appcachepath);

            Debug.WriteLine("Copying source appcache files...");

            FullCopy(_sourcepath, _destinationpath);

            Debug.WriteLine("Finished copying source appcache files...");
            /*
            Debug.WriteLine("Generating and comparing hashses...");
            if (HashChecking(_sourcepath, _destinationpath))
            {
                Debug.WriteLine("Hash check success!");
            }
            else { Debug.WriteLine("Hash fail."); }            
             */
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
        public void FullCopy(string source, string destination)
        {
            
            DirectoryInfo destdir = new DirectoryInfo(destination);

            List<string> sourceDirectories = GetAllDirectories(@"C:\Condenser\Source\");
            List<string> destDirectories = new List<string>();

            for (int i = 0; i < sourceDirectories.Count; i++)
            {
                DirectoryInfo sourcedir = new DirectoryInfo(source);
                if (!sourcedir.Exists)
                {
                    throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + source);
                }
                Debug.WriteLine("Creating directory: " + sourceDirectories[i]);
                destDirectories.Add(sourceDirectories[i].Replace(source, destination));
                Directory.CreateDirectory(destDirectories[i]);
            }

            List<string> sourceFiles = GetAllFiles(@"C:\Condenser\Source\");
            List<string> destFiles = new List<string>();

            for (int i = 0; i < sourceFiles.Count; i++)
            { 
                destFiles.Add(sourceFiles[i].Replace(source, destination));
                //Debug.WriteLine(destFiles[i]);
                ByteCopy(sourceFiles[i], destFiles[i]);
            }
            Debug.WriteLine("For loop finished!");                

        }

        public void ByteCopy(string path, string destination)
        {
            Debug.WriteLine("Running byte copy on: " + path);
            FileInfo f = new FileInfo(path);
            long size = f.Length;
            int isize = Convert.ToInt32(size);
            byte[] data = null;
            try
            {
                
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    Debug.WriteLine("Creating byte array of size: " + isize);
                    
                    data = reader.ReadBytes(isize);
                }
                //byte[] data = File.ReadAllBytes(path);
                Debug.WriteLine("Created byte array, about to write file...");
                //File.WriteAllBytes(destination, data);
                if (data != null)
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Open(destination, FileMode.Create)))
                    {
                        Debug.WriteLine("Writing file...");
                        writer.Write(data);
                        Debug.WriteLine("Created file!");
                    }
                }
                

            }
            catch
            {
                throw new FileLoadException("Couldn't load: " + path);                
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

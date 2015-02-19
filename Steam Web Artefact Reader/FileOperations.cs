using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Condenser
{
    class FileOperations
    {

        public string directorySteam, directoryConfig, directoryAppCache, configpath, cachepath;
        public string sourcepath, destinationpath;
        
        private string[] FilesConfig, FilesAppCache;

        public List<string> sourceAllFilesList = new List<string>();
        public List<string> sourceDirsList = new List<string>();
        public List<string> sourceConfigFilesList = new List<string>();
        public List<string> sourceAppCacheFilesList = new List<string>();
        

        /*public FileOperations(string _sourcepath, string _destinationpath)
        {
            sourcepath = _sourcepath;
            destinationpath = _destinationpath;
        }*/

        public FileOperations(string _sourcepath, string _destinationpath, string _cachepath, string _configpath)
        {
            sourcepath = _sourcepath;
            destinationpath = _destinationpath;
            cachepath = _cachepath;
            configpath = _configpath;
        }

        


        /// <summary>
        /// Recursively gets an array of all the files in the config directory.
        /// </summary>
        /// <returns>A string array of the config directory's files.</returns>
        public List<string> GetAllFiles()
        {
           
            directoryConfig = sourcepath + configpath;
            directoryAppCache = sourcepath + cachepath;

            // Grab files from directories.
            FilesConfig = Directory.GetFiles(directoryConfig, "*", System.IO.SearchOption.AllDirectories);
            FilesAppCache = Directory.GetFiles(directoryAppCache, "*", System.IO.SearchOption.AllDirectories);
            sourceAllFilesList.AddRange(FilesConfig);
            sourceAllFilesList.AddRange(FilesAppCache);

            return sourceAllFilesList;
        }

        public List<string> GetAllDirectories(string path)
        {

            directoryConfig = path + configpath;
            directoryAppCache = path + cachepath;

            Debug.WriteLine("Config Directory: " + directoryConfig);
            Debug.WriteLine("AppCache Directory: " + directoryAppCache);

            // Grab files from directories.

            string[] configDir = Directory.GetDirectories(directoryConfig, "*", System.IO.SearchOption.AllDirectories);
            string[] appCacheDir = Directory.GetDirectories(directoryAppCache, "*", System.IO.SearchOption.AllDirectories);

            //listprogress = 0;
            //listtotal = (FilesConfig.Length + FilesAppCache.Length);
            sourceDirsList.AddRange(configDir);
            sourceDirsList.AddRange(appCacheDir);

            Debug.WriteLine("Got directories...");
            return sourceDirsList;
        }




        public void FileCopy()
        {
            //Get config and appcache subdirs
            //string configpath = @"config\";
            //string cachepath = @"appcache\httpcache\";

            //List<string> configsubs = GetSubdirectories(sourcepath, configpath);
            //List<string> appcachesubs = GetSubdirectories(sourcepath, cachepath);

            //Copy config contents.
            string _destinationpath = Path.Combine(destinationpath, configpath);
            string _sourcepath = Path.Combine(sourcepath, configpath);
            Debug.WriteLine("Copying source config files...");
            Debug.WriteLine(destinationpath);

            FullCopy(sourcepath, destinationpath);//copy main config folder contents.
            
            Debug.WriteLine("Finished copying source Config files...");

            _destinationpath = Path.Combine(destinationpath, cachepath);
            _sourcepath = Path.Combine(sourcepath, cachepath);
            Debug.WriteLine(_destinationpath);
            Debug.WriteLine("Copying source appcache files...");

            //FullCopy(_sourcepath, _destinationpath);

            Debug.WriteLine("Finished copying source appcache files...");
            
            Debug.WriteLine("Generating and comparing hashses...");
            if (HashChecking(sourcepath, destinationpath))
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
        public void FullCopy(string source, string destination)
        {
            
            DirectoryInfo destdir = new DirectoryInfo(destination);

            List<string> sourceDirectories = GetAllDirectories(source);
            List<string> destDirectories = new List<string>();

            for (int i = 0; i < sourceDirectories.Count; i++)
            {
                DirectoryInfo sourcedir = new DirectoryInfo(source);
                if (!sourcedir.Exists)
                {
                    throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + source);
                }
                
                destDirectories.Add(sourceDirectories[i].Replace(source, destination));
                Debug.WriteLine("Creating directory: " + destDirectories[i]);
                Directory.CreateDirectory(destDirectories[i]);
            }

            List<string> sourceFiles = GetAllFiles();
            List<string> destFiles = new List<string>();

            Debug.WriteLine("File count: " + sourceFiles.Count);
            for (int i = 0; i < sourceFiles.Count; i++)
            { 
                destFiles.Add(sourceFiles[i].Replace(source, destination));
                Debug.WriteLine(destFiles[i]);
                Debug.WriteLine(source);
                Debug.WriteLine(destination);
                File.Copy(sourceFiles[i], destFiles[i], true);
            }
            Debug.WriteLine("For loop finished!");                

        }

       /* public void ByteCopy(string path, string destination)
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
                
                Debug.WriteLine("Created byte array, about to write file...");
                
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
        }*/

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

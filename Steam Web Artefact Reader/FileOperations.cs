using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Condenser
{
    class FileOperations
    {

        public string directoryConfig, directoryAppCache, configpath, cachepath;
        public string sourcepath, destinationpath;


        private string[] FilesConfig, FilesAppCache;

        public List<string> sourceAllFilesList = new List<string>();
        public List<string> sourceDirsList = new List<string>();       


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


            LogWrite.WriteLine("FO (Get Directories): Config Directory: " + directoryConfig);
            LogWrite.WriteLine("FO (Get Directories): AppCache Directory: " + directoryAppCache);

            // Grab files from directories.

            string[] configDir = Directory.GetDirectories(directoryConfig, "*", System.IO.SearchOption.AllDirectories);
            string[] appCacheDir = Directory.GetDirectories(directoryAppCache, "*", System.IO.SearchOption.AllDirectories);

            //listprogress = 0;
            //listtotal = (FilesConfig.Length + FilesAppCache.Length);
            sourceDirsList.AddRange(configDir);
            sourceDirsList.AddRange(appCacheDir);

            Debug.WriteLine("FO (Get Directories): Got directories.");
            return sourceDirsList;
        }




        public void FileCopy()
        {

            LogWrite.WriteLine("File Copy: Copying source files from " + sourcepath + " to " + destinationpath);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            FullCopy(sourcepath, destinationpath);
            sw.Stop();
            LogWrite.WriteLine("File Copy: Finished copying files in " + sw.ElapsedMilliseconds.ToString() + " milliseconds.");
            LogWrite.WriteLine("File Copy: Performing data integrity checks on copied files.");
            if (HashChecking(sourcepath, destinationpath))
            {
                LogWrite.WriteLine("File Copy: Hash check success for all files!");
            }
            else { LogWrite.WriteLine("File Copy: Hash failed on some files."); }
            MessageBox.Show("File Copying done!");
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
                LogWrite.WriteLine("File Copy: Creating directory: " + destDirectories[i]);
                Directory.CreateDirectory(destDirectories[i]);
            }

            List<string> sourceFiles = GetAllFiles();
            List<string> destFiles = new List<string>();

            LogWrite.WriteLine("File Copy: Number of files to be copied: " + sourceFiles.Count);
            for (int i = 0; i < sourceFiles.Count; i++)
            { 
                destFiles.Add(sourceFiles[i].Replace(source, destination));
                Debug.WriteLine(destFiles[i]);
                Debug.WriteLine(source);
                Debug.WriteLine(destination);
                try
                {
                    File.Copy(sourceFiles[i], destFiles[i], true);
                    LogWrite.WriteLine("File Copy: Copied file: " + sourceFiles[i]);
                }
                catch (Exception e)
                {
                    LogWrite.WriteLine("File Copy: Failed file copy for: " + sourceFiles[i] + " with exception " + e + ".");
                }
            }
            LogWrite.WriteLine("File Copy: Finished copy job.");                

        }

        public bool HashChecking(string source, string destination)
        { 
            bool hashsuccess = false;
            int d = 0;
            List<FileHashes> sourceHashes = new List<FileHashes>();
            List<FileHashes> destHashes = new List<FileHashes>();

           //Perhaps have it call GetAllFiles instead?

            foreach(string path in Directory.GetFiles(source, "*", SearchOption.AllDirectories))
            {
                LogWrite.WriteLine("File Copy: Generating MD5 and SHA1 Hash for: " + path);
                FileInfo FI = new FileInfo(path);
                sourceHashes.Add(new FileHashes 
                {                     
                    name = FI.Name,
                    filepath = path,
                    md5 = HashOperations.MD5Hash(path), 
                    sha1 = HashOperations.SHA1Hash(path)
                });
               
            }


            for (int i = 0; i < sourceHashes.Count; i++ )
            {
                try
                {
                    string dest = sourceHashes[i].filepath;
                    dest.Replace(source, destination);
                    if (File.Exists(dest))
                    {
                        string destmd5 = HashOperations.MD5Hash(dest);
                        string destsha1 = HashOperations.SHA1Hash(dest);

                        StringComparer c = StringComparer.OrdinalIgnoreCase;
                        if ((c.Compare(sourceHashes[i].md5, destmd5) == 0) && (c.Compare(sourceHashes[i].sha1, destsha1) == 0))
                        {
                            LogWrite.WriteLine("File Copy: MD5 and SHA1 match for " + dest);
                        }
                        else
                        {
                            LogWrite.WriteLine("File Copy: MD5 and SHA1 check failed for " + sourceHashes[i].filepath + " and " + dest);
                            d++;                            
                        }
                    }
                }

                catch (Exception e)
                {
                    MessageBox.Show("Issue occurred with hashing of files: " + e.ToString());
                }

                finally
                {
                    if ((d == 0))
                    {
                        hashsuccess = true;
                    }
                }
            }

            return hashsuccess;
        }
    }
}

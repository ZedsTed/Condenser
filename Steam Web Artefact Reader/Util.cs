﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condenser
{
    /// <summary>
    /// The Util class stores much of the information that Condenser relies upon, such as the source directory, the output directory, etc.
    /// NOT REALLY NEEDED.
    /// </summary>
    public class Util
    {
        //Set the default Steam installation directory.
        private string steamdir = @"C:\Program Files (x86)\Steam\";

        public string SteamDirectory
        {
            get 
            {
                return steamdir;
            }
            set 
            {
                steamdir = value;
            }
        }

        private string outputdir = System.Environment.CurrentDirectory;

        public string OutputDirectory
        {
            get 
            {
                return outputdir;
            }

            set 
            {
                outputdir = value;
            }
        }

        public static string configpath = @"\config\";

        public string ConfigPath
        {
            get
            {
                return configpath;
            }
            
        }


        public static string cachepath = @"\appcache\httpcache\";

        public string CachePath
        {
            get 
            {
                return cachepath;
            }
            
        }
    }


}

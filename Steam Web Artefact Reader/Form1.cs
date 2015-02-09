using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Condenser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CreateUtil();
            
        }
        public string source;
        public string output;
        public string cache = @"\appcache\httpcache\";
        public string config = @"\config\";

        public string Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }

        public string Output
        {
            get
            {
                return output;
            }
            set
            {
                output = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
 
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }




        private void fileSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                       

        }

        private void fileModifiedLabel_Click(object sender, EventArgs e)
        {

        }

        public void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void newSession_Click_1(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked.");
            steamDirBrowser.ShowDialog();
            Source = steamDirBrowser.SelectedPath;
            
            Debug.WriteLine("source: " + source);

            outputBrowser.SelectedPath = System.Environment.CurrentDirectory;
            outputBrowser.ShowDialog();
            Output = outputBrowser.SelectedPath;


            
            

            Debug.WriteLine("dest: " + output);

            PopulateFileList();
            
       
        }

        public void PopulateFileList()
        {
            FileOperations FO = new FileOperations(source, output, config, cache);
            List<string> steamFiles = FO.GetAllFiles();
            for (int i = 0; i < steamFiles.Count; i++)
            {
                SteamFileInfo FI = new SteamFileInfo(steamFiles[i]);

                string name = FI.GetFileName();
                string path = FI.GetFilePath();
                string size = (FI.GetFileSize() + " bytes");
                string accessdate = FI.GetAccessDate();
                string creationdate = FI.GetCreationDate();
                string modifieddate = FI.GetModifiedDate();

                string md5 = FI.GetMD5Hash();
                string sha1 = FI.GetSHA1Hash();
                   
                ListViewItem item = new ListViewItem(new[] {name, path, size, accessdate, creationdate, modifieddate, md5, sha1});
                CompleteFileListView.Items.Add(item);
                
            }
        }

        private void CompleteFileListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string selectedFile = FileListBox.SelectedItem.ToString();

            SteamFileInfo FI = new SteamFileInfo(selectedFile);

            fileNameOut.Text = FI.GetFileName();
            fileSizeOut.Text = (FI.GetFileSize() + " bytes");
            accessDateOut.Text = FI.GetAccessDate();
            creationDateOut.Text = FI.GetCreationDate();
            modifiedDateOut.Text = FI.GetModifiedDate();

            MD5Out.Text = FI.GetMD5Hash();
            SHA1Out.Text = FI.GetSHA1Hash(); */      
        }



        public Util SetupUtils(string source, string output)
        {
            Util util = new Util();
            util.SteamDirectory = source;
            util.OutputDirectory = output;            

            return util;
        }
        

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {            
            MessageBox.Show(e.Context.ToString());
            e.Cancel = true;
            
        }

        private void loadCookiesTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteReader reader = new SQLiteReader(@"C:\Program Files (x86)\Steam\config\htmlcache\Cookies;");

            DataTable dbout = reader.GetConnection();

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dbout;
            dataGridView1.ReadOnly = true;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {   //We don't want to output any byte arrays to the data grid.
                if (dataGridView1.Columns[i].ValueType.ToString() == "System.Byte[]")
                {
                    dataGridView1.Columns[i].Visible = false;
                }
            }
        }

        private void findSteamDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        
           
        }

        private void copyWebBrowserDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //FileOperations FO = new FileOperations(@"C:\Condenser\Source\", @"C:\Condenser\");
            //Run File Operations on a new thread to allow the user to use the UI during the process.
            //Thread copyThread = new Thread(new ThreadStart(FO.FileCopy));
            
            //copyThread.Start();
            Debug.WriteLine("Clicked.");
            //fileCopyWorker.RunWorkerAsync();
            
            
            //Thread carveThread = new Thread(new ThreadStart(FO.CarveIdentify));

            //carveThread.Start();


        }

        private void fileCopyWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Debug.WriteLine("starting...");
            FileOperations FO = new FileOperations(source, output, cache, config);
            FO.FileCopy();
            //fileCopyWorker.ReportProgress(FO.listprogress);
        }

        private void fileCopyWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            ProgressBar.Value = e.ProgressPercentage;
            // Set the text.
            this.Text = e.ProgressPercentage.ToString();
        }

        private void fileCarveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileCarver FC = new FileCarver();
            FC.Carve(FC.GetBytes(@"C:\Condenser\Source\appcache\httpcache\4d\4dae7c301df8ec1046ffbb82cda40c7377c8dc85_da39a3ee5e6b4b0d3255bfef95601890afd80709"));

        }

        private void steamDirBrowser_HelpRequest(object sender, EventArgs e)
        {

        }





        
    }
}

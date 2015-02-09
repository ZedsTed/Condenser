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

        /*public Util CreateUtil()
        {
            Util u = new Util();

            return u;
        }*/

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

            fileNameOut.Text = " ";
            fileSizeOut.Text = " ";
            accessDateOut.Text = " ";
            creationDateOut.Text = " ";
            modifiedDateOut.Text = " ";

            MD5Out.Text = " ";
            SHA1Out.Text = " ";

        }

        private void fileModifiedLabel_Click(object sender, EventArgs e)
        {

        }

        public void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFile = FileListBox.SelectedItem.ToString();

            SteamFileInfo fileinfo = new SteamFileInfo(selectedFile);

            fileNameOut.Text = fileinfo.GetFileName();
            fileSizeOut.Text = fileinfo.GetFileSize();
            accessDateOut.Text = fileinfo.GetAccessDate();
            creationDateOut.Text = fileinfo.GetCreationDate();
            modifiedDateOut.Text = fileinfo.GetModifiedDate();

            MD5Out.Text = fileinfo.GetMD5Hash();
            SHA1Out.Text = fileinfo.GetSHA1Hash();            
        }

        private void newSession_Click_1(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked.");
            steamDirBrowser.ShowDialog();
            string source = steamDirBrowser.SelectedPath;
            
            Debug.WriteLine("source: " + source);

            outputBrowser.SelectedPath = System.Environment.CurrentDirectory;
            outputBrowser.ShowDialog();
            string output = outputBrowser.SelectedPath;

            SetupUtils(source, output);

            Debug.WriteLine("dest: " + output);
        }

        public Util SetupUtils(string source, string output)
        {
            Util u = new Util();
            u.SteamDirectory = source;
            u.OutputDirectory = output;

            return u;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {            
            MessageBox.Show(e.Context.ToString());
            e.Cancel = true;
        }

        private void loadCookiesTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLiteReader reader = new SQLiteReader();

            DataTable dbout = reader.GetConnection();

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dbout;
            dataGridView1.ReadOnly = true;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].ValueType.ToString() == "System.Byte[]")
                {
                    dataGridView1.Columns[i].Visible = false;
                }
            }
        }

        private void findSteamDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FileOperations FI = new FileOperations();
            List<string> steamFiles = FI.GetAllFiles(FI.SteamDirectory());
            foreach (string path in steamFiles)
            {
                FileListBox.Items.Add(path);
            }            
           
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
            FileOperations FO = new FileOperations(@"C:\Condenser\Source\", @"C:\Condenser\Image\");
            FO.FileCopy();
            //fileCopyWorker.ReportProgress(FO.listprogress);
        }

        private void fileCopyWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            fileCopyBar.Value = e.ProgressPercentage;
            // Set the text.
            this.Text = e.ProgressPercentage.ToString();
        }

        private void fileCarveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileCarver FC = new FileCarver();
            FC.Carve(FC.GetBytes(@"C:\Condenser\Source\appcache\httpcache\4d\4dae7c301df8ec1046ffbb82cda40c7377c8dc85_da39a3ee5e6b4b0d3255bfef95601890afd80709"));

            /*StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < stream.Length; i++)
            {
                sBuilder.Append(stream[i].ToString("x2"));
            }

            string streamString = sBuilder.ToString();

            richTextBox1.Text = streamString;*/
        }

        private void steamDirBrowser_HelpRequest(object sender, EventArgs e)
        {

        }



        
    }
}

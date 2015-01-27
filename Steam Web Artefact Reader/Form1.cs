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

namespace Steam_Web_Artefact_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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



        private void newSession_Click(object sender, EventArgs e)
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
            FileOperations FO = new FileOperations(@"C:\Program Files (x86)\Steam\", @"C:\Condenser\");
            Thread thread = new Thread(new ThreadStart(FO.FileCopy));
            
            thread.Start();
            
        }



        
    }
}

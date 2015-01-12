using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readCookie_Click(object sender, EventArgs e)
        {
            SQLiteReader reader = new SQLiteReader();

            DataTable dbout = reader.sqlRead();

            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dbout;
            
            /*
            for (int i = 0; i <= strout.Length; i++ )
            {
                cookieDisplay.AppendText(strout[i]);
            }*/
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void newSession_Click(object sender, EventArgs e)
        {
            SteamDirParser steamDir = new SteamDirParser();

            string userSteamDir = steamDir.findSteamDir();

            dirOutput.Text = userSteamDir;


            List<string> steamFiles = steamDir.listSteamFiles(true, true);
            foreach (string path in steamFiles)
            {
                FileListBox.Items.Add(path);
            }
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
            string selectedFile = FileListBox.SelectedItem.ToString();

            SteamFileInfo fileinfo = new SteamFileInfo(selectedFile);

            fileSizeOut.Text = fileinfo.GetFileSize();
            accessDateOut.Text = fileinfo.GetAccessDate();
            creationDateOut.Text = fileinfo.GetCreationDate();
            modifiedDateOut.Text = fileinfo.GetModifiedDate();

            MD5Out.Text = fileinfo.GetMD5Hash();
            SHA1Out.Text = fileinfo.GetSHA1Hash();

            //return selectedFile;
        }

        private void newSession_Click_1(object sender, EventArgs e)
        {
            SteamDirParser steamDir = new SteamDirParser();

            string userSteamDir = steamDir.findSteamDir();

            dirOutput.Text = userSteamDir;


            List<string> steamFiles = steamDir.listSteamFiles(true, true);
            foreach (string path in steamFiles)
            {
                FileListBox.Items.Add(path);
            }
        }

        
    }
}

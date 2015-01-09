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
        private void parseFiles_Click(object sender, EventArgs e)
        {
            SteamDirParser steamDir = new SteamDirParser();
           
            string userSteamDir = steamDir.findSteamDir();

            dirOutput.Text = userSteamDir;
            

            string[] steamFilesAppCache = steamDir.listSteamFilesAppCache();
            foreach (string path in steamFilesAppCache)
            {
                steamDirListAppCache.AppendText(path + Environment.NewLine);
            }

            string[] steamFilesConfig = steamDir.listSteamFilesConfig();
            foreach (string path in steamFilesConfig)
            {
                steamDirListConfig.AppendText(path + Environment.NewLine);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readCookie_Click(object sender, EventArgs e)
        {
            SQLiteReader reader = new SQLiteReader();

            DataTable dbout = reader.sqlRead();

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void md5check_Click(object sender, EventArgs e)
        {
            HashReader md5hasher = new HashReader(@"C:\hash", true, true);
            string md5hash =  md5hasher.GetMD5Hash();
            hashDisplay.AppendText(md5hash + "\n"); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sha1check_Click(object sender, EventArgs e)
        {
            HashReader sha1hasher = new HashReader(@"C:\hash", true, true);
            string sha1hash = sha1hasher.GetSHA1Hash();
            hashDisplay.AppendText(sha1hash + "\n"); 
        }

        
    }
}

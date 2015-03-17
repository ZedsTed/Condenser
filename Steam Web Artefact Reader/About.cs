using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condenser
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openGitButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/ZedsTed/Condenser");
        }

        private void userGuideButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/ZedsTed/Condenser/wiki");
        }

        private void closeDialogButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

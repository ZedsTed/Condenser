namespace Condenser
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSession = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discoverWebBrowserDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageWebBrowserDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCookiesTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCookiesTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupCookiesDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileCarveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carveSingleFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carveFolderContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataIntegrityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5HashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA1HashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSteamDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steamDirBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.outputBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.CompleteFileListView = new System.Windows.Forms.ListView();
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accessdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creationdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modifieddate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.md5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sha1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carverFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cookiesDBGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1108, 398);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSession});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSession
            // 
            this.newSession.Name = "newSession";
            this.newSession.Size = new System.Drawing.Size(152, 22);
            this.newSession.Text = "New Session";
            this.newSession.Click += new System.EventHandler(this.newSession_Click_1);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discoverWebBrowserDataToolStripMenuItem,
            this.imageWebBrowserDataToolStripMenuItem,
            this.outputToCSVToolStripMenuItem,
            this.sQLiteToolStripMenuItem,
            this.fileCarveToolStripMenuItem,
            this.dataIntegrityToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // discoverWebBrowserDataToolStripMenuItem
            // 
            this.discoverWebBrowserDataToolStripMenuItem.Name = "discoverWebBrowserDataToolStripMenuItem";
            this.discoverWebBrowserDataToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.discoverWebBrowserDataToolStripMenuItem.Text = "Discover Web Browser Data";
            this.discoverWebBrowserDataToolStripMenuItem.Click += new System.EventHandler(this.discoverWebBrowserDataToolStripMenuItem_Click);
            // 
            // imageWebBrowserDataToolStripMenuItem
            // 
            this.imageWebBrowserDataToolStripMenuItem.Name = "imageWebBrowserDataToolStripMenuItem";
            this.imageWebBrowserDataToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.imageWebBrowserDataToolStripMenuItem.Text = "Copy Web Browser Data";
            this.imageWebBrowserDataToolStripMenuItem.Click += new System.EventHandler(this.imageWebBrowserDataToolStripMenuItem_Click);
            // 
            // outputToCSVToolStripMenuItem
            // 
            this.outputToCSVToolStripMenuItem.Name = "outputToCSVToolStripMenuItem";
            this.outputToCSVToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.outputToCSVToolStripMenuItem.Text = "Output to CSV";
            this.outputToCSVToolStripMenuItem.Click += new System.EventHandler(this.outputToCSVToolStripMenuItem_Click);
            // 
            // sQLiteToolStripMenuItem
            // 
            this.sQLiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCookiesTableToolStripMenuItem,
            this.refreshCookiesTableToolStripMenuItem,
            this.backupCookiesDatabaseToolStripMenuItem});
            this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
            this.sQLiteToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.sQLiteToolStripMenuItem.Text = "SQLite Reader";
            // 
            // loadCookiesTableToolStripMenuItem
            // 
            this.loadCookiesTableToolStripMenuItem.Name = "loadCookiesTableToolStripMenuItem";
            this.loadCookiesTableToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.loadCookiesTableToolStripMenuItem.Text = "Load Cookies Table";
            this.loadCookiesTableToolStripMenuItem.Click += new System.EventHandler(this.loadCookiesTableToolStripMenuItem_Click);
            // 
            // refreshCookiesTableToolStripMenuItem
            // 
            this.refreshCookiesTableToolStripMenuItem.Name = "refreshCookiesTableToolStripMenuItem";
            this.refreshCookiesTableToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.refreshCookiesTableToolStripMenuItem.Text = "Refresh Cookies Table";
            // 
            // backupCookiesDatabaseToolStripMenuItem
            // 
            this.backupCookiesDatabaseToolStripMenuItem.Name = "backupCookiesDatabaseToolStripMenuItem";
            this.backupCookiesDatabaseToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.backupCookiesDatabaseToolStripMenuItem.Text = "Backup Cookies Database";
            // 
            // fileCarveToolStripMenuItem
            // 
            this.fileCarveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carveSingleFileToolStripMenuItem,
            this.carveFolderContentsToolStripMenuItem});
            this.fileCarveToolStripMenuItem.Name = "fileCarveToolStripMenuItem";
            this.fileCarveToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.fileCarveToolStripMenuItem.Text = "File Carve";
            this.fileCarveToolStripMenuItem.Click += new System.EventHandler(this.fileCarveToolStripMenuItem_Click);
            // 
            // carveSingleFileToolStripMenuItem
            // 
            this.carveSingleFileToolStripMenuItem.Name = "carveSingleFileToolStripMenuItem";
            this.carveSingleFileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.carveSingleFileToolStripMenuItem.Text = "Carve Single File";
            this.carveSingleFileToolStripMenuItem.Click += new System.EventHandler(this.carveSingleFileToolStripMenuItem_Click);
            // 
            // carveFolderContentsToolStripMenuItem
            // 
            this.carveFolderContentsToolStripMenuItem.Name = "carveFolderContentsToolStripMenuItem";
            this.carveFolderContentsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.carveFolderContentsToolStripMenuItem.Text = "Carve Folder Contents";
            this.carveFolderContentsToolStripMenuItem.Click += new System.EventHandler(this.carveFolderContentsToolStripMenuItem_Click);
            // 
            // dataIntegrityToolStripMenuItem
            // 
            this.dataIntegrityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mD5HashToolStripMenuItem,
            this.sHA1HashToolStripMenuItem});
            this.dataIntegrityToolStripMenuItem.Name = "dataIntegrityToolStripMenuItem";
            this.dataIntegrityToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.dataIntegrityToolStripMenuItem.Text = "File Operations";
            // 
            // mD5HashToolStripMenuItem
            // 
            this.mD5HashToolStripMenuItem.Name = "mD5HashToolStripMenuItem";
            this.mD5HashToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.mD5HashToolStripMenuItem.Text = "MD5 Hash File..";
            // 
            // sHA1HashToolStripMenuItem
            // 
            this.sHA1HashToolStripMenuItem.Name = "sHA1HashToolStripMenuItem";
            this.sHA1HashToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sHA1HashToolStripMenuItem.Text = "SHA1 Hash File...";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSteamDirectoryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // changeSteamDirectoryToolStripMenuItem
            // 
            this.changeSteamDirectoryToolStripMenuItem.Name = "changeSteamDirectoryToolStripMenuItem";
            this.changeSteamDirectoryToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.changeSteamDirectoryToolStripMenuItem.Text = "Change Directories";
            this.changeSteamDirectoryToolStripMenuItem.Click += new System.EventHandler(this.changeSteamDirectoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugInformationToolStripMenuItem,
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // debugInformationToolStripMenuItem
            // 
            this.debugInformationToolStripMenuItem.Name = "debugInformationToolStripMenuItem";
            this.debugInformationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.debugInformationToolStripMenuItem.Text = "View Logs";
            this.debugInformationToolStripMenuItem.Click += new System.EventHandler(this.debugInformationToolStripMenuItem_Click);
            // 
            // aboutSteamWebArtefactReaderSWARToolStripMenuItem
            // 
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Name = "aboutSteamWebArtefactReaderSWARToolStripMenuItem";
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Text = "About Condenser";
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Click += new System.EventHandler(this.aboutSteamWebArtefactReaderSWARToolStripMenuItem_Click);
            // 
            // steamDirBrowser
            // 
            this.steamDirBrowser.Description = "Please select the Steam installation\'s root folder.";
            this.steamDirBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.steamDirBrowser.ShowNewFolderButton = false;
            this.steamDirBrowser.HelpRequest += new System.EventHandler(this.steamDirBrowser_HelpRequest);
            // 
            // outputBrowser
            // 
            this.outputBrowser.Description = "Please select your desired output folder for Condenser\'s File Operations.";
            this.outputBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // CompleteFileListView
            // 
            this.CompleteFileListView.AllowColumnReorder = true;
            this.CompleteFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            this.path,
            this.size,
            this.accessdate,
            this.creationdate,
            this.modifieddate,
            this.md5,
            this.sha1});
            this.CompleteFileListView.Location = new System.Drawing.Point(13, 28);
            this.CompleteFileListView.Name = "CompleteFileListView";
            this.CompleteFileListView.Size = new System.Drawing.Size(1120, 289);
            this.CompleteFileListView.TabIndex = 21;
            this.CompleteFileListView.UseCompatibleStateImageBehavior = false;
            this.CompleteFileListView.View = System.Windows.Forms.View.Details;
            this.CompleteFileListView.SelectedIndexChanged += new System.EventHandler(this.CompleteFileListView_SelectedIndexChanged);
            // 
            // filename
            // 
            this.filename.Text = "Name";
            this.filename.Width = 156;
            // 
            // path
            // 
            this.path.Text = "Path";
            this.path.Width = 88;
            // 
            // size
            // 
            this.size.Text = "Size (bytes)";
            this.size.Width = 97;
            // 
            // accessdate
            // 
            this.accessdate.Text = "Access Date";
            // 
            // creationdate
            // 
            this.creationdate.Text = "Creation Date";
            // 
            // modifieddate
            // 
            this.modifieddate.Text = "Modified Date";
            // 
            // md5
            // 
            this.md5.Text = "MD5 Hash";
            // 
            // sha1
            // 
            this.sha1.Text = "SHA1 Hash";
            // 
            // carverFolderBrowser
            // 
            this.carverFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.carverFolderBrowser.ShowNewFolderButton = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cookiesDBGroupBox
            // 
            this.cookiesDBGroupBox.Location = new System.Drawing.Point(13, 324);
            this.cookiesDBGroupBox.Name = "cookiesDBGroupBox";
            this.cookiesDBGroupBox.Size = new System.Drawing.Size(1120, 420);
            this.cookiesDBGroupBox.TabIndex = 22;
            this.cookiesDBGroupBox.TabStop = false;
            this.cookiesDBGroupBox.Text = "Cookies Database";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 756);
            this.Controls.Add(this.CompleteFileListView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cookiesDBGroupBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Condenser: A Steam Artefact and Metadata Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSession;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSteamDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSteamWebArtefactReaderSWARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataIntegrityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5HashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA1HashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCookiesTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshCookiesTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileCarveToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog steamDirBrowser;
        private System.Windows.Forms.FolderBrowserDialog outputBrowser;
        private System.Windows.Forms.ToolStripMenuItem backupCookiesDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageWebBrowserDataToolStripMenuItem;
        private System.Windows.Forms.ListView CompleteFileListView;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader accessdate;
        private System.Windows.Forms.ColumnHeader creationdate;
        private System.Windows.Forms.ColumnHeader modifieddate;
        private System.Windows.Forms.ColumnHeader md5;
        private System.Windows.Forms.ColumnHeader sha1;
        private System.Windows.Forms.ToolStripMenuItem discoverWebBrowserDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carveSingleFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carveFolderContentsToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog carverFolderBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox cookiesDBGroupBox;
    }
}


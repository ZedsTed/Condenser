namespace Steam_Web_Artefact_Reader
{
    partial class Form1
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
            this.parseFiles = new System.Windows.Forms.Button();
            this.steamDirListAppCache = new System.Windows.Forms.RichTextBox();
            this.dirOutput = new System.Windows.Forms.TextBox();
            this.steamDirListConfig = new System.Windows.Forms.RichTextBox();
            this.readCookie = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hashDisplay = new System.Windows.Forms.RichTextBox();
            this.md5check = new System.Windows.Forms.Button();
            this.sha1check = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookieAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookiesTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSteamDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parseFiles
            // 
            this.parseFiles.Location = new System.Drawing.Point(13, 38);
            this.parseFiles.Name = "parseFiles";
            this.parseFiles.Size = new System.Drawing.Size(95, 23);
            this.parseFiles.TabIndex = 0;
            this.parseFiles.Text = "Find Steam Files";
            this.parseFiles.UseVisualStyleBackColor = true;
            this.parseFiles.Click += new System.EventHandler(this.parseFiles_Click);
            // 
            // steamDirListAppCache
            // 
            this.steamDirListAppCache.Location = new System.Drawing.Point(13, 107);
            this.steamDirListAppCache.Name = "steamDirListAppCache";
            this.steamDirListAppCache.Size = new System.Drawing.Size(246, 151);
            this.steamDirListAppCache.TabIndex = 1;
            this.steamDirListAppCache.Text = "";
            // 
            // dirOutput
            // 
            this.dirOutput.Location = new System.Drawing.Point(224, 81);
            this.dirOutput.Name = "dirOutput";
            this.dirOutput.Size = new System.Drawing.Size(414, 20);
            this.dirOutput.TabIndex = 2;
            // 
            // steamDirListConfig
            // 
            this.steamDirListConfig.Location = new System.Drawing.Point(265, 118);
            this.steamDirListConfig.Name = "steamDirListConfig";
            this.steamDirListConfig.Size = new System.Drawing.Size(232, 140);
            this.steamDirListConfig.TabIndex = 3;
            this.steamDirListConfig.Text = "";
            // 
            // readCookie
            // 
            this.readCookie.Location = new System.Drawing.Point(114, 38);
            this.readCookie.Name = "readCookie";
            this.readCookie.Size = new System.Drawing.Size(104, 23);
            this.readCookie.TabIndex = 4;
            this.readCookie.Text = "Read Cookie File";
            this.readCookie.UseVisualStyleBackColor = true;
            this.readCookie.Click += new System.EventHandler(this.readCookie_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(13, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 323);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // hashDisplay
            // 
            this.hashDisplay.Location = new System.Drawing.Point(13, 275);
            this.hashDisplay.Name = "hashDisplay";
            this.hashDisplay.Size = new System.Drawing.Size(282, 123);
            this.hashDisplay.TabIndex = 5;
            this.hashDisplay.Text = "";
            // 
            // md5check
            // 
            this.md5check.Location = new System.Drawing.Point(13, 67);
            this.md5check.Name = "md5check";
            this.md5check.Size = new System.Drawing.Size(95, 34);
            this.md5check.TabIndex = 7;
            this.md5check.Text = "MD5 Hash Check";
            this.md5check.UseVisualStyleBackColor = true;
            this.md5check.Click += new System.EventHandler(this.md5check_Click);
            // 
            // sha1check
            // 
            this.sha1check.Location = new System.Drawing.Point(114, 67);
            this.sha1check.Name = "sha1check";
            this.sha1check.Size = new System.Drawing.Size(104, 34);
            this.sha1check.TabIndex = 7;
            this.sha1check.Text = "SHA1 Hash Check";
            this.sha1check.UseVisualStyleBackColor = true;
            this.sha1check.Click += new System.EventHandler(this.sha1check_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cookieAnalysisToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSteamDirectoryToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
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
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newSessionToolStripMenuItem.Text = "New Session";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // cookieAnalysisToolStripMenuItem
            // 
            this.cookieAnalysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayTableToolStripMenuItem});
            this.cookieAnalysisToolStripMenuItem.Name = "cookieAnalysisToolStripMenuItem";
            this.cookieAnalysisToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cookieAnalysisToolStripMenuItem.Text = "Cookie Analysis";
            // 
            // displayTableToolStripMenuItem
            // 
            this.displayTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cookiesTableToolStripMenuItem});
            this.displayTableToolStripMenuItem.Name = "displayTableToolStripMenuItem";
            this.displayTableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayTableToolStripMenuItem.Text = "Display Table";
            // 
            // cookiesTableToolStripMenuItem
            // 
            this.cookiesTableToolStripMenuItem.Name = "cookiesTableToolStripMenuItem";
            this.cookiesTableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cookiesTableToolStripMenuItem.Text = "Cookies Table";
            // 
            // changeSteamDirectoryToolStripMenuItem
            // 
            this.changeSteamDirectoryToolStripMenuItem.Name = "changeSteamDirectoryToolStripMenuItem";
            this.changeSteamDirectoryToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.changeSteamDirectoryToolStripMenuItem.Text = "Change Steam Directory";
            // 
            // debugInformationToolStripMenuItem
            // 
            this.debugInformationToolStripMenuItem.Name = "debugInformationToolStripMenuItem";
            this.debugInformationToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.debugInformationToolStripMenuItem.Text = "Debug Information";
            // 
            // aboutSteamWebArtefactReaderSWARToolStripMenuItem
            // 
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Name = "aboutSteamWebArtefactReaderSWARToolStripMenuItem";
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Text = "About Steam Web Artefact Reader (SWAR)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 756);
            this.Controls.Add(this.sha1check);
            this.Controls.Add(this.md5check);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.hashDisplay);
            this.Controls.Add(this.readCookie);
            this.Controls.Add(this.steamDirListConfig);
            this.Controls.Add(this.dirOutput);
            this.Controls.Add(this.steamDirListAppCache);
            this.Controls.Add(this.parseFiles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Condenser: A Steam Artefact and Metadata Tool";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parseFiles;
        private System.Windows.Forms.RichTextBox steamDirListAppCache;
        private System.Windows.Forms.TextBox dirOutput;
        private System.Windows.Forms.RichTextBox steamDirListConfig;
        private System.Windows.Forms.Button readCookie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.RichTextBox hashDisplay;
        private System.Windows.Forms.Button md5check;
        private System.Windows.Forms.Button sha1check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookieAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookiesTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSteamDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSteamWebArtefactReaderSWARToolStripMenuItem;
    }
}


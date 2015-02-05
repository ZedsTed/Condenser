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
            this.dirOutput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSession = new System.Windows.Forms.ToolStripMenuItem();
            this.findSteamDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyWebBrowserDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCookiesTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCookiesTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataIntegrityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5HashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA1HashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSteamDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.fileNameOut = new System.Windows.Forms.Label();
            this.fileSizeOut = new System.Windows.Forms.Label();
            this.fileCreationLabel = new System.Windows.Forms.Label();
            this.fileAccessLabel = new System.Windows.Forms.Label();
            this.fileModifiedLabel = new System.Windows.Forms.Label();
            this.MD5HashLabel = new System.Windows.Forms.Label();
            this.SHA1HashLabel = new System.Windows.Forms.Label();
            this.MD5Out = new System.Windows.Forms.Label();
            this.SHA1Out = new System.Windows.Forms.Label();
            this.creationDateOut = new System.Windows.Forms.Label();
            this.accessDateOut = new System.Windows.Forms.Label();
            this.modifiedDateOut = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fileCarveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dirOutput
            // 
            this.dirOutput.Location = new System.Drawing.Point(12, 27);
            this.dirOutput.Name = "dirOutput";
            this.dirOutput.Size = new System.Drawing.Size(414, 20);
            this.dirOutput.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(915, 421);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.newSession,
            this.openItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSession
            // 
            this.newSession.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findSteamDirectoryToolStripMenuItem,
            this.copyWebBrowserDataToolStripMenuItem});
            this.newSession.Name = "newSession";
            this.newSession.Size = new System.Drawing.Size(140, 22);
            this.newSession.Text = "New Session";
            this.newSession.Click += new System.EventHandler(this.newSession_Click_1);
            // 
            // findSteamDirectoryToolStripMenuItem
            // 
            this.findSteamDirectoryToolStripMenuItem.Name = "findSteamDirectoryToolStripMenuItem";
            this.findSteamDirectoryToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.findSteamDirectoryToolStripMenuItem.Text = "Find Steam Directory";
            this.findSteamDirectoryToolStripMenuItem.Click += new System.EventHandler(this.findSteamDirectoryToolStripMenuItem_Click);
            // 
            // copyWebBrowserDataToolStripMenuItem
            // 
            this.copyWebBrowserDataToolStripMenuItem.Name = "copyWebBrowserDataToolStripMenuItem";
            this.copyWebBrowserDataToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.copyWebBrowserDataToolStripMenuItem.Text = "Copy Web Browser Data";
            this.copyWebBrowserDataToolStripMenuItem.Click += new System.EventHandler(this.copyWebBrowserDataToolStripMenuItem_Click);
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(140, 22);
            this.openItem.Text = "Open";
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
            this.sQLiteToolStripMenuItem,
            this.dataIntegrityToolStripMenuItem,
            this.fileCarveToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // sQLiteToolStripMenuItem
            // 
            this.sQLiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCookiesTableToolStripMenuItem,
            this.refreshCookiesTableToolStripMenuItem});
            this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
            this.sQLiteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sQLiteToolStripMenuItem.Text = "SQLite Reader";
            // 
            // loadCookiesTableToolStripMenuItem
            // 
            this.loadCookiesTableToolStripMenuItem.Name = "loadCookiesTableToolStripMenuItem";
            this.loadCookiesTableToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.loadCookiesTableToolStripMenuItem.Text = "Load Cookies Table";
            this.loadCookiesTableToolStripMenuItem.Click += new System.EventHandler(this.loadCookiesTableToolStripMenuItem_Click);
            // 
            // refreshCookiesTableToolStripMenuItem
            // 
            this.refreshCookiesTableToolStripMenuItem.Name = "refreshCookiesTableToolStripMenuItem";
            this.refreshCookiesTableToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.refreshCookiesTableToolStripMenuItem.Text = "Refresh Cookies Table";
            // 
            // dataIntegrityToolStripMenuItem
            // 
            this.dataIntegrityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mD5HashToolStripMenuItem,
            this.sHA1HashToolStripMenuItem});
            this.dataIntegrityToolStripMenuItem.Name = "dataIntegrityToolStripMenuItem";
            this.dataIntegrityToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.dataIntegrityToolStripMenuItem.Text = "Data Integrity";
            // 
            // mD5HashToolStripMenuItem
            // 
            this.mD5HashToolStripMenuItem.Name = "mD5HashToolStripMenuItem";
            this.mD5HashToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.mD5HashToolStripMenuItem.Text = "MD5 Hash";
            // 
            // sHA1HashToolStripMenuItem
            // 
            this.sHA1HashToolStripMenuItem.Name = "sHA1HashToolStripMenuItem";
            this.sHA1HashToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sHA1HashToolStripMenuItem.Text = "SHA1 Hash";
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
            this.changeSteamDirectoryToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.changeSteamDirectoryToolStripMenuItem.Text = "Change Steam Directory";
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
            this.debugInformationToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.debugInformationToolStripMenuItem.Text = "Debug Information";
            // 
            // aboutSteamWebArtefactReaderSWARToolStripMenuItem
            // 
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Name = "aboutSteamWebArtefactReaderSWARToolStripMenuItem";
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Size = new System.Drawing.Size(297, 22);
            this.aboutSteamWebArtefactReaderSWARToolStripMenuItem.Text = "About Steam Web Artefact Reader (SWAR)";
            // 
            // FileListBox
            // 
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.Location = new System.Drawing.Point(12, 53);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(639, 264);
            this.FileListBox.TabIndex = 9;
            this.FileListBox.SelectedIndexChanged += new System.EventHandler(this.FileListBox_SelectedIndexChanged);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(657, 53);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fileNameLabel.TabIndex = 10;
            this.fileNameLabel.Text = "File Name:";
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(657, 66);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(49, 13);
            this.fileSizeLabel.TabIndex = 11;
            this.fileSizeLabel.Text = "File Size:";
            this.fileSizeLabel.Click += new System.EventHandler(this.fileSizeLabel_Click);
            // 
            // fileNameOut
            // 
            this.fileNameOut.AutoSize = true;
            this.fileNameOut.Location = new System.Drawing.Point(748, 53);
            this.fileNameOut.Name = "fileNameOut";
            this.fileNameOut.Size = new System.Drawing.Size(22, 13);
            this.fileNameOut.TabIndex = 12;
            this.fileNameOut.Text = "foo";
            this.fileNameOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fileSizeOut
            // 
            this.fileSizeOut.AutoSize = true;
            this.fileSizeOut.Location = new System.Drawing.Point(748, 66);
            this.fileSizeOut.Name = "fileSizeOut";
            this.fileSizeOut.Size = new System.Drawing.Size(22, 13);
            this.fileSizeOut.TabIndex = 13;
            this.fileSizeOut.Text = "foo";
            this.fileSizeOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fileCreationLabel
            // 
            this.fileCreationLabel.AutoSize = true;
            this.fileCreationLabel.Location = new System.Drawing.Point(657, 79);
            this.fileCreationLabel.Name = "fileCreationLabel";
            this.fileCreationLabel.Size = new System.Drawing.Size(75, 13);
            this.fileCreationLabel.TabIndex = 11;
            this.fileCreationLabel.Text = "Creation Date:";
            this.fileCreationLabel.Click += new System.EventHandler(this.fileSizeLabel_Click);
            // 
            // fileAccessLabel
            // 
            this.fileAccessLabel.AutoSize = true;
            this.fileAccessLabel.Location = new System.Drawing.Point(657, 92);
            this.fileAccessLabel.Name = "fileAccessLabel";
            this.fileAccessLabel.Size = new System.Drawing.Size(71, 13);
            this.fileAccessLabel.TabIndex = 14;
            this.fileAccessLabel.Text = "Access Date:";
            // 
            // fileModifiedLabel
            // 
            this.fileModifiedLabel.AutoSize = true;
            this.fileModifiedLabel.Location = new System.Drawing.Point(657, 105);
            this.fileModifiedLabel.Name = "fileModifiedLabel";
            this.fileModifiedLabel.Size = new System.Drawing.Size(79, 13);
            this.fileModifiedLabel.TabIndex = 15;
            this.fileModifiedLabel.Text = "Modified Date: ";
            this.fileModifiedLabel.Click += new System.EventHandler(this.fileModifiedLabel_Click);
            // 
            // MD5HashLabel
            // 
            this.MD5HashLabel.AutoSize = true;
            this.MD5HashLabel.Location = new System.Drawing.Point(657, 118);
            this.MD5HashLabel.Name = "MD5HashLabel";
            this.MD5HashLabel.Size = new System.Drawing.Size(61, 13);
            this.MD5HashLabel.TabIndex = 16;
            this.MD5HashLabel.Text = "MD5 Hash:";
            // 
            // SHA1HashLabel
            // 
            this.SHA1HashLabel.AutoSize = true;
            this.SHA1HashLabel.Location = new System.Drawing.Point(657, 131);
            this.SHA1HashLabel.Name = "SHA1HashLabel";
            this.SHA1HashLabel.Size = new System.Drawing.Size(66, 13);
            this.SHA1HashLabel.TabIndex = 17;
            this.SHA1HashLabel.Text = "SHA1 Hash:";
            // 
            // MD5Out
            // 
            this.MD5Out.AutoSize = true;
            this.MD5Out.Location = new System.Drawing.Point(748, 118);
            this.MD5Out.Name = "MD5Out";
            this.MD5Out.Size = new System.Drawing.Size(22, 13);
            this.MD5Out.TabIndex = 18;
            this.MD5Out.Text = "foo";
            this.MD5Out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SHA1Out
            // 
            this.SHA1Out.AutoSize = true;
            this.SHA1Out.Location = new System.Drawing.Point(748, 131);
            this.SHA1Out.Name = "SHA1Out";
            this.SHA1Out.Size = new System.Drawing.Size(22, 13);
            this.SHA1Out.TabIndex = 18;
            this.SHA1Out.Text = "foo";
            this.SHA1Out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // creationDateOut
            // 
            this.creationDateOut.AutoSize = true;
            this.creationDateOut.Location = new System.Drawing.Point(748, 79);
            this.creationDateOut.Name = "creationDateOut";
            this.creationDateOut.Size = new System.Drawing.Size(22, 13);
            this.creationDateOut.TabIndex = 13;
            this.creationDateOut.Text = "foo";
            this.creationDateOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accessDateOut
            // 
            this.accessDateOut.AutoSize = true;
            this.accessDateOut.Location = new System.Drawing.Point(748, 92);
            this.accessDateOut.Name = "accessDateOut";
            this.accessDateOut.Size = new System.Drawing.Size(22, 13);
            this.accessDateOut.TabIndex = 13;
            this.accessDateOut.Text = "foo";
            this.accessDateOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modifiedDateOut
            // 
            this.modifiedDateOut.AutoSize = true;
            this.modifiedDateOut.Location = new System.Drawing.Point(748, 105);
            this.modifiedDateOut.Name = "modifiedDateOut";
            this.modifiedDateOut.Size = new System.Drawing.Size(22, 13);
            this.modifiedDateOut.TabIndex = 13;
            this.modifiedDateOut.Text = "foo";
            this.modifiedDateOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(658, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 169);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // fileCarveToolStripMenuItem
            // 
            this.fileCarveToolStripMenuItem.Name = "fileCarveToolStripMenuItem";
            this.fileCarveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileCarveToolStripMenuItem.Text = "File Carve";
            this.fileCarveToolStripMenuItem.Click += new System.EventHandler(this.fileCarveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 756);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SHA1Out);
            this.Controls.Add(this.MD5Out);
            this.Controls.Add(this.SHA1HashLabel);
            this.Controls.Add(this.MD5HashLabel);
            this.Controls.Add(this.fileModifiedLabel);
            this.Controls.Add(this.fileAccessLabel);
            this.Controls.Add(this.modifiedDateOut);
            this.Controls.Add(this.accessDateOut);
            this.Controls.Add(this.creationDateOut);
            this.Controls.Add(this.fileSizeOut);
            this.Controls.Add(this.fileNameOut);
            this.Controls.Add(this.fileCreationLabel);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dirOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Condenser: A Steam Artefact and Metadata Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dirOutput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSession;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSteamDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSteamWebArtefactReaderSWARToolStripMenuItem;
        private System.Windows.Forms.ListBox FileListBox;
        private System.Windows.Forms.ToolStripMenuItem dataIntegrityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5HashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA1HashToolStripMenuItem;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label fileNameOut;
        private System.Windows.Forms.Label fileSizeOut;
        private System.Windows.Forms.Label fileCreationLabel;
        private System.Windows.Forms.Label fileAccessLabel;
        private System.Windows.Forms.Label fileModifiedLabel;
        private System.Windows.Forms.Label MD5HashLabel;
        private System.Windows.Forms.Label SHA1HashLabel;
        private System.Windows.Forms.Label MD5Out;
        private System.Windows.Forms.Label SHA1Out;
        private System.Windows.Forms.Label creationDateOut;
        private System.Windows.Forms.Label accessDateOut;
        private System.Windows.Forms.Label modifiedDateOut;
        private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCookiesTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshCookiesTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findSteamDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyWebBrowserDataToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem fileCarveToolStripMenuItem;
    }
}


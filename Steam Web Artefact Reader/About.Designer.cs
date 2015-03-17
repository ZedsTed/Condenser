namespace Condenser
{
    partial class About
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
            this.CondenserLabel = new System.Windows.Forms.Label();
            this.SteamMetadataLabel = new System.Windows.Forms.Label();
            this.verLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.licenceLabel = new System.Windows.Forms.Label();
            this.GitHubBox = new System.Windows.Forms.GroupBox();
            this.openGitButton = new System.Windows.Forms.Button();
            this.closeDialogButton = new System.Windows.Forms.Button();
            this.userGuideBox = new System.Windows.Forms.GroupBox();
            this.userGuideButton = new System.Windows.Forms.Button();
            this.gitHubText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GitHubBox.SuspendLayout();
            this.userGuideBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CondenserLabel
            // 
            this.CondenserLabel.AutoSize = true;
            this.CondenserLabel.Location = new System.Drawing.Point(12, 13);
            this.CondenserLabel.Name = "CondenserLabel";
            this.CondenserLabel.Size = new System.Drawing.Size(61, 13);
            this.CondenserLabel.TabIndex = 0;
            this.CondenserLabel.Text = "Condenser:";
            // 
            // SteamMetadataLabel
            // 
            this.SteamMetadataLabel.AutoSize = true;
            this.SteamMetadataLabel.Location = new System.Drawing.Point(12, 26);
            this.SteamMetadataLabel.Name = "SteamMetadataLabel";
            this.SteamMetadataLabel.Size = new System.Drawing.Size(206, 13);
            this.SteamMetadataLabel.TabIndex = 0;
            this.SteamMetadataLabel.Text = "A Steam Web Artefact and Metadata Tool";
            this.SteamMetadataLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.Location = new System.Drawing.Point(12, 55);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(66, 13);
            this.verLabel.TabIndex = 1;
            this.verLabel.Text = "Version 0.1a";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(12, 68);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(105, 13);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "(c) Ted Everett 2015";
            // 
            // licenceLabel
            // 
            this.licenceLabel.AutoSize = true;
            this.licenceLabel.Location = new System.Drawing.Point(12, 81);
            this.licenceLabel.Name = "licenceLabel";
            this.licenceLabel.Size = new System.Drawing.Size(120, 13);
            this.licenceLabel.TabIndex = 3;
            this.licenceLabel.Text = "Licenced under GPLv3.";
            // 
            // GitHubBox
            // 
            this.GitHubBox.Controls.Add(this.gitHubText);
            this.GitHubBox.Controls.Add(this.openGitButton);
            this.GitHubBox.Location = new System.Drawing.Point(12, 120);
            this.GitHubBox.Name = "GitHubBox";
            this.GitHubBox.Size = new System.Drawing.Size(260, 91);
            this.GitHubBox.TabIndex = 4;
            this.GitHubBox.TabStop = false;
            this.GitHubBox.Text = "GitHub Page";
            // 
            // openGitButton
            // 
            this.openGitButton.Location = new System.Drawing.Point(46, 54);
            this.openGitButton.Name = "openGitButton";
            this.openGitButton.Size = new System.Drawing.Size(171, 23);
            this.openGitButton.TabIndex = 1;
            this.openGitButton.Text = "Open Condenser GitHub Page";
            this.openGitButton.UseVisualStyleBackColor = true;
            this.openGitButton.Click += new System.EventHandler(this.openGitButton_Click);
            // 
            // closeDialogButton
            // 
            this.closeDialogButton.Location = new System.Drawing.Point(99, 336);
            this.closeDialogButton.Name = "closeDialogButton";
            this.closeDialogButton.Size = new System.Drawing.Size(75, 23);
            this.closeDialogButton.TabIndex = 5;
            this.closeDialogButton.Text = "Close";
            this.closeDialogButton.UseVisualStyleBackColor = true;
            this.closeDialogButton.Click += new System.EventHandler(this.closeDialogButton_Click);
            // 
            // userGuideBox
            // 
            this.userGuideBox.Controls.Add(this.textBox1);
            this.userGuideBox.Controls.Add(this.userGuideButton);
            this.userGuideBox.Location = new System.Drawing.Point(12, 227);
            this.userGuideBox.Name = "userGuideBox";
            this.userGuideBox.Size = new System.Drawing.Size(260, 90);
            this.userGuideBox.TabIndex = 6;
            this.userGuideBox.TabStop = false;
            this.userGuideBox.Text = "User Guide";
            // 
            // userGuideButton
            // 
            this.userGuideButton.Location = new System.Drawing.Point(46, 52);
            this.userGuideButton.Name = "userGuideButton";
            this.userGuideButton.Size = new System.Drawing.Size(173, 23);
            this.userGuideButton.TabIndex = 1;
            this.userGuideButton.Text = "Open Condenser User Guide";
            this.userGuideButton.UseVisualStyleBackColor = true;
            this.userGuideButton.Click += new System.EventHandler(this.userGuideButton_Click);
            // 
            // gitHubText
            // 
            this.gitHubText.BackColor = System.Drawing.SystemColors.Control;
            this.gitHubText.Location = new System.Drawing.Point(18, 28);
            this.gitHubText.Name = "gitHubText";
            this.gitHubText.ReadOnly = true;
            this.gitHubText.Size = new System.Drawing.Size(224, 20);
            this.gitHubText.TabIndex = 2;
            this.gitHubText.Text = "https://github.com/ZedsTed/Condenser";
            this.gitHubText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "https://github.com/ZedsTed/Condenser/wiki";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.userGuideBox);
            this.Controls.Add(this.closeDialogButton);
            this.Controls.Add(this.GitHubBox);
            this.Controls.Add(this.licenceLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.verLabel);
            this.Controls.Add(this.SteamMetadataLabel);
            this.Controls.Add(this.CondenserLabel);
            this.Name = "About";
            this.Text = "About";
            this.GitHubBox.ResumeLayout(false);
            this.GitHubBox.PerformLayout();
            this.userGuideBox.ResumeLayout(false);
            this.userGuideBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CondenserLabel;
        private System.Windows.Forms.Label SteamMetadataLabel;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label licenceLabel;
        private System.Windows.Forms.GroupBox GitHubBox;
        private System.Windows.Forms.Button openGitButton;
        private System.Windows.Forms.Button closeDialogButton;
        private System.Windows.Forms.GroupBox userGuideBox;
        private System.Windows.Forms.Button userGuideButton;
        private System.Windows.Forms.TextBox gitHubText;
        private System.Windows.Forms.TextBox textBox1;

    }
}
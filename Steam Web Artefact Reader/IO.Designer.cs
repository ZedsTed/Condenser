namespace Condenser
{
    partial class IO
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
            this.IOtext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // IOtext
            // 
            this.IOtext.BackColor = System.Drawing.SystemColors.MenuText;
            this.IOtext.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IOtext.ForeColor = System.Drawing.Color.DarkGreen;
            this.IOtext.Location = new System.Drawing.Point(12, 12);
            this.IOtext.Name = "IOtext";
            this.IOtext.Size = new System.Drawing.Size(605, 262);
            this.IOtext.TabIndex = 0;
            this.IOtext.Text = "";
            // 
            // IO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 286);
            this.Controls.Add(this.IOtext);
            this.Name = "IO";
            this.Text = "Information Output";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox IOtext;

    }
}
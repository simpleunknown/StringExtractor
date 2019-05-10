namespace FolderBrowserDialogSampleInCSharp
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
            this.BrowseFolderButton = new System.Windows.Forms.Button();
            this.filebutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GenStrings = new System.Windows.Forms.Button();
            this.explist = new System.Windows.Forms.Button();
            this.Dictionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrowseFolderButton
            // 
            this.BrowseFolderButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BrowseFolderButton.ForeColor = System.Drawing.Color.Green;
            this.BrowseFolderButton.Location = new System.Drawing.Point(137, 75);
            this.BrowseFolderButton.Name = "BrowseFolderButton";
            this.BrowseFolderButton.Size = new System.Drawing.Size(98, 28);
            this.BrowseFolderButton.TabIndex = 0;
            this.BrowseFolderButton.Text = "Browse Folder containing DLL";
            this.BrowseFolderButton.UseVisualStyleBackColor = false;
            this.BrowseFolderButton.Click += new System.EventHandler(this.BrowseFolderButton_Click);
            // 
            // filebutton
            // 
            this.filebutton.BackColor = System.Drawing.Color.Black;
            this.filebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.filebutton.Location = new System.Drawing.Point(402, 75);
            this.filebutton.Name = "filebutton";
            this.filebutton.Size = new System.Drawing.Size(98, 28);
            this.filebutton.TabIndex = 2;
            this.filebutton.Text = "Open File containing DLL";
            this.filebutton.UseVisualStyleBackColor = false;
            this.filebutton.Click += new System.EventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Location = new System.Drawing.Point(80, 124);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(500, 193);
            this.textBox2.TabIndex = 3;
            // 
            // GenStrings
            // 
            this.GenStrings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenStrings.ForeColor = System.Drawing.Color.Aqua;
            this.GenStrings.Location = new System.Drawing.Point(252, 355);
            this.GenStrings.Name = "GenStrings";
            this.GenStrings.Size = new System.Drawing.Size(186, 46);
            this.GenStrings.TabIndex = 4;
            this.GenStrings.Text = "Generate Strings";
            this.GenStrings.UseVisualStyleBackColor = false;
            this.GenStrings.Click += new System.EventHandler(this.GenStrings_click);
            // 
            // explist
            // 
            this.explist.Location = new System.Drawing.Point(619, 200);
            this.explist.Name = "explist";
            this.explist.Size = new System.Drawing.Size(75, 23);
            this.explist.TabIndex = 5;
            this.explist.Text = "Export_list";
            this.explist.UseVisualStyleBackColor = true;
            this.explist.Click += new System.EventHandler(this.explist_Click);
            // 
            // Dictionary
            // 
            this.Dictionary.Location = new System.Drawing.Point(486, 355);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(133, 45);
            this.Dictionary.TabIndex = 6;
            this.Dictionary.Text = "Dictionary File";
            this.Dictionary.UseVisualStyleBackColor = true;
            this.Dictionary.Click += new System.EventHandler(this.Dict_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 522);
            this.Controls.Add(this.Dictionary);
            this.Controls.Add(this.explist);
            this.Controls.Add(this.GenStrings);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.filebutton);
            this.Controls.Add(this.BrowseFolderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseFolderButton;
        private System.Windows.Forms.Button filebutton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button GenStrings;
        private System.Windows.Forms.Button explist;
        private System.Windows.Forms.Button Dictionary;
    }
}


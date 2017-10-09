namespace BitcoinWallet
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputSeed = new System.Windows.Forms.TextBox();
            this.inputGenerate = new System.Windows.Forms.Button();
            this.inputSaveToFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seed:";
            // 
            // outputSeed
            // 
            this.outputSeed.Location = new System.Drawing.Point(101, 47);
            this.outputSeed.Name = "outputSeed";
            this.outputSeed.ReadOnly = true;
            this.outputSeed.Size = new System.Drawing.Size(508, 20);
            this.outputSeed.TabIndex = 9;
            // 
            // inputGenerate
            // 
            this.inputGenerate.Location = new System.Drawing.Point(11, 12);
            this.inputGenerate.Name = "inputGenerate";
            this.inputGenerate.Size = new System.Drawing.Size(75, 23);
            this.inputGenerate.TabIndex = 7;
            this.inputGenerate.Text = "Generate";
            this.inputGenerate.UseVisualStyleBackColor = true;
            this.inputGenerate.Click += new System.EventHandler(this.inputGenerate_Click);
            // 
            // inputSaveToFile
            // 
            this.inputSaveToFile.Location = new System.Drawing.Point(101, 12);
            this.inputSaveToFile.Name = "inputSaveToFile";
            this.inputSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.inputSaveToFile.TabIndex = 11;
            this.inputSaveToFile.Text = "Save to file";
            this.inputSaveToFile.UseVisualStyleBackColor = true;
            this.inputSaveToFile.Click += new System.EventHandler(this.inputSaveToFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 217);
            this.Controls.Add(this.inputSaveToFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputSeed);
            this.Controls.Add(this.inputGenerate);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitcoin Wallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputSeed;
        private System.Windows.Forms.Button inputGenerate;
        private System.Windows.Forms.Button inputSaveToFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


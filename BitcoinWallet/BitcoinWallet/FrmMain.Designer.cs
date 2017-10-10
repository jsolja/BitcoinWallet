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
            this.inputSaveToFileEnc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputEncSeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputDecSeed = new System.Windows.Forms.TextBox();
            this.inputDecrypt = new System.Windows.Forms.Button();
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
            this.inputSaveToFile.Size = new System.Drawing.Size(126, 23);
            this.inputSaveToFile.TabIndex = 11;
            this.inputSaveToFile.Text = "Save to file in plain";
            this.inputSaveToFile.UseVisualStyleBackColor = true;
            this.inputSaveToFile.Click += new System.EventHandler(this.inputSaveToFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // inputSaveToFileEnc
            // 
            this.inputSaveToFileEnc.Location = new System.Drawing.Point(233, 12);
            this.inputSaveToFileEnc.Name = "inputSaveToFileEnc";
            this.inputSaveToFileEnc.Size = new System.Drawing.Size(123, 23);
            this.inputSaveToFileEnc.TabIndex = 12;
            this.inputSaveToFileEnc.Text = "Save to file encrypted";
            this.inputSaveToFileEnc.UseVisualStyleBackColor = true;
            this.inputSaveToFileEnc.Click += new System.EventHandler(this.inputSaveToFileEnc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Encrypted:";
            // 
            // outputEncSeed
            // 
            this.outputEncSeed.Location = new System.Drawing.Point(101, 73);
            this.outputEncSeed.Name = "outputEncSeed";
            this.outputEncSeed.ReadOnly = true;
            this.outputEncSeed.Size = new System.Drawing.Size(508, 20);
            this.outputEncSeed.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Decrypted:";
            // 
            // outputDecSeed
            // 
            this.outputDecSeed.Location = new System.Drawing.Point(101, 185);
            this.outputDecSeed.Name = "outputDecSeed";
            this.outputDecSeed.ReadOnly = true;
            this.outputDecSeed.Size = new System.Drawing.Size(508, 20);
            this.outputDecSeed.TabIndex = 16;
            // 
            // inputDecrypt
            // 
            this.inputDecrypt.Location = new System.Drawing.Point(233, 156);
            this.inputDecrypt.Name = "inputDecrypt";
            this.inputDecrypt.Size = new System.Drawing.Size(123, 23);
            this.inputDecrypt.TabIndex = 17;
            this.inputDecrypt.Text = "Decrypt file";
            this.inputDecrypt.UseVisualStyleBackColor = true;
            this.inputDecrypt.Click += new System.EventHandler(this.inputDecrypt_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 217);
            this.Controls.Add(this.inputDecrypt);
            this.Controls.Add(this.outputDecSeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputEncSeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputSaveToFileEnc);
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
        private System.Windows.Forms.Button inputSaveToFileEnc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputEncSeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputDecSeed;
        private System.Windows.Forms.Button inputDecrypt;
    }
}


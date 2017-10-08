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
            this.label3 = new System.Windows.Forms.Label();
            this.outputMasterkey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputSeed = new System.Windows.Forms.TextBox();
            this.outputKeys = new System.Windows.Forms.TextBox();
            this.inputGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Child keys:";
            // 
            // outputMasterkey
            // 
            this.outputMasterkey.Location = new System.Drawing.Point(102, 65);
            this.outputMasterkey.Name = "outputMasterkey";
            this.outputMasterkey.ReadOnly = true;
            this.outputMasterkey.Size = new System.Drawing.Size(832, 20);
            this.outputMasterkey.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Master key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seed:";
            // 
            // outputSeed
            // 
            this.outputSeed.Location = new System.Drawing.Point(102, 38);
            this.outputSeed.Name = "outputSeed";
            this.outputSeed.ReadOnly = true;
            this.outputSeed.Size = new System.Drawing.Size(832, 20);
            this.outputSeed.TabIndex = 9;
            // 
            // outputKeys
            // 
            this.outputKeys.Location = new System.Drawing.Point(102, 91);
            this.outputKeys.Multiline = true;
            this.outputKeys.Name = "outputKeys";
            this.outputKeys.ReadOnly = true;
            this.outputKeys.Size = new System.Drawing.Size(832, 396);
            this.outputKeys.TabIndex = 8;
            // 
            // inputGenerate
            // 
            this.inputGenerate.Location = new System.Drawing.Point(11, 9);
            this.inputGenerate.Name = "inputGenerate";
            this.inputGenerate.Size = new System.Drawing.Size(75, 23);
            this.inputGenerate.TabIndex = 7;
            this.inputGenerate.Text = "Generate";
            this.inputGenerate.UseVisualStyleBackColor = true;
            this.inputGenerate.Click += new System.EventHandler(this.inputGenerate_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputMasterkey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputSeed);
            this.Controls.Add(this.outputKeys);
            this.Controls.Add(this.inputGenerate);
            this.Name = "FrmMain";
            this.Text = "Bitcoin Wallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputMasterkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputSeed;
        private System.Windows.Forms.TextBox outputKeys;
        private System.Windows.Forms.Button inputGenerate;
    }
}


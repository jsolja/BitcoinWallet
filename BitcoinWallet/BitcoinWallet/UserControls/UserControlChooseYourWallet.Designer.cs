namespace BitcoinWallet.Class
{
    partial class UserControlChooseYourWallet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputChooseWallet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputChooseWalletText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choose your wallet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Press \'Next\' to create this wallet, or choose another file.";
            // 
            // inputChooseWallet
            // 
            this.inputChooseWallet.Location = new System.Drawing.Point(314, 35);
            this.inputChooseWallet.Name = "inputChooseWallet";
            this.inputChooseWallet.Size = new System.Drawing.Size(75, 23);
            this.inputChooseWallet.TabIndex = 8;
            this.inputChooseWallet.Text = "Choose...";
            this.inputChooseWallet.UseVisualStyleBackColor = true;
            this.inputChooseWallet.Click += new System.EventHandler(this.inputChooseWallet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "This file does not exist.";
            // 
            // inputChooseWalletText
            // 
            this.inputChooseWalletText.Location = new System.Drawing.Point(58, 37);
            this.inputChooseWalletText.Name = "inputChooseWalletText";
            this.inputChooseWalletText.Size = new System.Drawing.Size(250, 20);
            this.inputChooseWalletText.TabIndex = 7;
            this.inputChooseWalletText.Text = "default_wallet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wallet:";
            // 
            // UserControlChooseYourWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputChooseWallet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputChooseWalletText);
            this.Controls.Add(this.label1);
            this.Name = "UserControlChooseYourWallet";
            this.Size = new System.Drawing.Size(404, 345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inputChooseWallet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputChooseWalletText;
        private System.Windows.Forms.Label label1;
    }
}

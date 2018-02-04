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
            this.outputLabelNext = new System.Windows.Forms.Label();
            this.inputChooseWallet = new System.Windows.Forms.Button();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.inputChooseWalletText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.outputLabelPassword = new System.Windows.Forms.Label();
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
            // outputLabelNext
            // 
            this.outputLabelNext.AutoSize = true;
            this.outputLabelNext.Location = new System.Drawing.Point(13, 95);
            this.outputLabelNext.Name = "outputLabelNext";
            this.outputLabelNext.Size = new System.Drawing.Size(267, 13);
            this.outputLabelNext.TabIndex = 10;
            this.outputLabelNext.Text = "Press \'Next\' to create this wallet, or choose another file.";
            // 
            // inputChooseWallet
            // 
            this.inputChooseWallet.Location = new System.Drawing.Point(417, 35);
            this.inputChooseWallet.Name = "inputChooseWallet";
            this.inputChooseWallet.Size = new System.Drawing.Size(75, 23);
            this.inputChooseWallet.TabIndex = 8;
            this.inputChooseWallet.Text = "Choose...";
            this.inputChooseWallet.UseVisualStyleBackColor = true;
            this.inputChooseWallet.Click += new System.EventHandler(this.inputChooseWallet_Click);
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(13, 73);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(114, 13);
            this.outputFileLabel.TabIndex = 9;
            this.outputFileLabel.Text = "This file does not exist.";
            // 
            // inputChooseWalletText
            // 
            this.inputChooseWalletText.Location = new System.Drawing.Point(58, 37);
            this.inputChooseWalletText.Name = "inputChooseWalletText";
            this.inputChooseWalletText.Size = new System.Drawing.Size(353, 20);
            this.inputChooseWalletText.TabIndex = 7;
            this.inputChooseWalletText.Text = "default_wallet.dat";
            this.inputChooseWalletText.TextChanged += new System.EventHandler(this.inputChooseWalletText_TextChanged);
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
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(75, 114);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(134, 20);
            this.inputPassword.TabIndex = 12;
            this.inputPassword.UseSystemPasswordChar = true;
            this.inputPassword.Visible = false;
            // 
            // outputLabelPassword
            // 
            this.outputLabelPassword.AutoSize = true;
            this.outputLabelPassword.Location = new System.Drawing.Point(13, 117);
            this.outputLabelPassword.Name = "outputLabelPassword";
            this.outputLabelPassword.Size = new System.Drawing.Size(56, 13);
            this.outputLabelPassword.TabIndex = 13;
            this.outputLabelPassword.Text = "Password:";
            this.outputLabelPassword.Visible = false;
            // 
            // UserControlChooseYourWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputLabelPassword);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputLabelNext);
            this.Controls.Add(this.inputChooseWallet);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.inputChooseWalletText);
            this.Controls.Add(this.label1);
            this.Name = "UserControlChooseYourWallet";
            this.Size = new System.Drawing.Size(495, 345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputLabelNext;
        private System.Windows.Forms.Button inputChooseWallet;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.TextBox inputChooseWalletText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label outputLabelPassword;
    }
}

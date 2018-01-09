namespace BitcoinWallet.UserControls
{
    partial class UserControlReceive
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
            this.receivingAdressLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.requestedAmountLabel = new System.Windows.Forms.Label();
            this.receivingAdressTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.mBTCLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // receivingAdressLabel
            // 
            this.receivingAdressLabel.AutoSize = true;
            this.receivingAdressLabel.Location = new System.Drawing.Point(25, 22);
            this.receivingAdressLabel.Name = "receivingAdressLabel";
            this.receivingAdressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.receivingAdressLabel.Size = new System.Drawing.Size(95, 13);
            this.receivingAdressLabel.TabIndex = 0;
            this.receivingAdressLabel.Text = "Receiving address";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(25, 48);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // requestedAmountLabel
            // 
            this.requestedAmountLabel.AutoSize = true;
            this.requestedAmountLabel.Location = new System.Drawing.Point(25, 75);
            this.requestedAmountLabel.Name = "requestedAmountLabel";
            this.requestedAmountLabel.Size = new System.Drawing.Size(97, 13);
            this.requestedAmountLabel.TabIndex = 2;
            this.requestedAmountLabel.Text = "Requested amount";
            // 
            // receivingAdressTextBox
            // 
            this.receivingAdressTextBox.Location = new System.Drawing.Point(157, 14);
            this.receivingAdressTextBox.Name = "receivingAdressTextBox";
            this.receivingAdressTextBox.Size = new System.Drawing.Size(260, 20);
            this.receivingAdressTextBox.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(157, 40);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(260, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(157, 72);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(113, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // mBTCLabel
            // 
            this.mBTCLabel.AutoSize = true;
            this.mBTCLabel.Location = new System.Drawing.Point(276, 75);
            this.mBTCLabel.Name = "mBTCLabel";
            this.mBTCLabel.Size = new System.Drawing.Size(36, 13);
            this.mBTCLabel.TabIndex = 6;
            this.mBTCLabel.Text = "mBTC";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(68, 125);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save to wallet";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(210, 124);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(129, 23);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generate new adress";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(479, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 120);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.mBTCLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.receivingAdressTextBox);
            this.Controls.Add(this.requestedAmountLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.receivingAdressLabel);
            this.Name = "UserControlReceive";
            this.Size = new System.Drawing.Size(633, 208);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label receivingAdressLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label requestedAmountLabel;
        private System.Windows.Forms.TextBox receivingAdressTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label mBTCLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

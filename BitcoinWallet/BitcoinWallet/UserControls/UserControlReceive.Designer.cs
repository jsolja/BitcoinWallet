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
            this.inputReceiving = new System.Windows.Forms.TextBox();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.inputRequestedAmount = new System.Windows.Forms.TextBox();
            this.mBTCLabel = new System.Windows.Forms.Label();
            this.inputSave = new System.Windows.Forms.Button();
            this.inputGenerateNewAdress = new System.Windows.Forms.Button();
            this.outputQRcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.outputQRcode)).BeginInit();
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
            // inputReceiving
            // 
            this.inputReceiving.Location = new System.Drawing.Point(157, 14);
            this.inputReceiving.Name = "inputReceiving";
            this.inputReceiving.ReadOnly = true;
            this.inputReceiving.Size = new System.Drawing.Size(425, 20);
            this.inputReceiving.TabIndex = 3;
            this.inputReceiving.TextChanged += new System.EventHandler(this.receivingAdressTextBox_TextChanged);
            // 
            // inputDescription
            // 
            this.inputDescription.Location = new System.Drawing.Point(157, 40);
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(425, 20);
            this.inputDescription.TabIndex = 4;
            this.inputDescription.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // inputRequestedAmount
            // 
            this.inputRequestedAmount.Location = new System.Drawing.Point(157, 72);
            this.inputRequestedAmount.Name = "inputRequestedAmount";
            this.inputRequestedAmount.Size = new System.Drawing.Size(113, 20);
            this.inputRequestedAmount.TabIndex = 5;
            this.inputRequestedAmount.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
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
            // inputSave
            // 
            this.inputSave.Location = new System.Drawing.Point(68, 125);
            this.inputSave.Name = "inputSave";
            this.inputSave.Size = new System.Drawing.Size(102, 23);
            this.inputSave.TabIndex = 7;
            this.inputSave.Text = "Save to wallet";
            this.inputSave.UseVisualStyleBackColor = true;
            this.inputSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // inputGenerateNewAdress
            // 
            this.inputGenerateNewAdress.Location = new System.Drawing.Point(210, 124);
            this.inputGenerateNewAdress.Name = "inputGenerateNewAdress";
            this.inputGenerateNewAdress.Size = new System.Drawing.Size(129, 23);
            this.inputGenerateNewAdress.TabIndex = 8;
            this.inputGenerateNewAdress.Text = "Generate new adress";
            this.inputGenerateNewAdress.UseVisualStyleBackColor = true;
            this.inputGenerateNewAdress.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // outputQRcode
            // 
            this.outputQRcode.Location = new System.Drawing.Point(392, 84);
            this.outputQRcode.Name = "outputQRcode";
            this.outputQRcode.Size = new System.Drawing.Size(190, 170);
            this.outputQRcode.TabIndex = 9;
            this.outputQRcode.TabStop = false;
            // 
            // UserControlReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.outputQRcode);
            this.Controls.Add(this.inputGenerateNewAdress);
            this.Controls.Add(this.inputSave);
            this.Controls.Add(this.mBTCLabel);
            this.Controls.Add(this.inputRequestedAmount);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.inputReceiving);
            this.Controls.Add(this.requestedAmountLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.receivingAdressLabel);
            this.Name = "UserControlReceive";
            this.Size = new System.Drawing.Size(610, 352);
            ((System.ComponentModel.ISupportInitialize)(this.outputQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label receivingAdressLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label requestedAmountLabel;
        private System.Windows.Forms.TextBox inputReceiving;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.TextBox inputRequestedAmount;
        private System.Windows.Forms.Label mBTCLabel;
        private System.Windows.Forms.Button inputSave;
        private System.Windows.Forms.Button inputGenerateNewAdress;
        private System.Windows.Forms.PictureBox outputQRcode;
    }
}

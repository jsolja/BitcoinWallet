namespace BitcoinWallet.UserControls
{
    partial class UserControlSend
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
            this.inputSend = new System.Windows.Forms.Button();
            this.inputPreview = new System.Windows.Forms.Button();
            this.InputClear = new System.Windows.Forms.Button();
            this.inputAllAvailable = new System.Windows.Forms.Button();
            this.mBTCLabel = new System.Windows.Forms.Label();
            this.inputFee = new System.Windows.Forms.TrackBar();
            this.inputAmount = new System.Windows.Forms.TextBox();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.inputPayTo = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.payToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputFee)).BeginInit();
            this.SuspendLayout();
            // 
            // inputSend
            // 
            this.inputSend.Location = new System.Drawing.Point(269, 219);
            this.inputSend.Name = "inputSend";
            this.inputSend.Size = new System.Drawing.Size(75, 23);
            this.inputSend.TabIndex = 26;
            this.inputSend.Text = "Send";
            this.inputSend.UseVisualStyleBackColor = true;
            this.inputSend.Click += new System.EventHandler(this.inputSend_Click);
            // 
            // inputPreview
            // 
            this.inputPreview.Location = new System.Drawing.Point(179, 219);
            this.inputPreview.Name = "inputPreview";
            this.inputPreview.Size = new System.Drawing.Size(75, 23);
            this.inputPreview.TabIndex = 25;
            this.inputPreview.Text = "Preview";
            this.inputPreview.UseVisualStyleBackColor = true;
            // 
            // InputClear
            // 
            this.InputClear.Location = new System.Drawing.Point(86, 219);
            this.InputClear.Name = "InputClear";
            this.InputClear.Size = new System.Drawing.Size(75, 23);
            this.InputClear.TabIndex = 24;
            this.InputClear.Text = "Clear";
            this.InputClear.UseVisualStyleBackColor = true;
            this.InputClear.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // inputAllAvailable
            // 
            this.inputAllAvailable.Location = new System.Drawing.Point(244, 74);
            this.inputAllAvailable.Name = "inputAllAvailable";
            this.inputAllAvailable.Size = new System.Drawing.Size(84, 23);
            this.inputAllAvailable.TabIndex = 23;
            this.inputAllAvailable.Text = "All available";
            this.inputAllAvailable.UseVisualStyleBackColor = true;
            // 
            // mBTCLabel
            // 
            this.mBTCLabel.AutoSize = true;
            this.mBTCLabel.Location = new System.Drawing.Point(193, 79);
            this.mBTCLabel.Name = "mBTCLabel";
            this.mBTCLabel.Size = new System.Drawing.Size(36, 13);
            this.mBTCLabel.TabIndex = 22;
            this.mBTCLabel.Text = "mBTC";
            // 
            // inputFee
            // 
            this.inputFee.BackColor = System.Drawing.SystemColors.Window;
            this.inputFee.LargeChange = 1;
            this.inputFee.Location = new System.Drawing.Point(86, 139);
            this.inputFee.Maximum = 5;
            this.inputFee.Minimum = 1;
            this.inputFee.Name = "inputFee";
            this.inputFee.Size = new System.Drawing.Size(100, 45);
            this.inputFee.TabIndex = 21;
            this.inputFee.Value = 1;
            // 
            // inputAmount
            // 
            this.inputAmount.Location = new System.Drawing.Point(86, 76);
            this.inputAmount.Name = "inputAmount";
            this.inputAmount.Size = new System.Drawing.Size(100, 20);
            this.inputAmount.TabIndex = 20;
            // 
            // inputDescription
            // 
            this.inputDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDescription.Location = new System.Drawing.Point(86, 52);
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.Size = new System.Drawing.Size(430, 20);
            this.inputDescription.TabIndex = 19;
            // 
            // inputPayTo
            // 
            this.inputPayTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPayTo.Location = new System.Drawing.Point(86, 29);
            this.inputPayTo.Name = "inputPayTo";
            this.inputPayTo.Size = new System.Drawing.Size(430, 20);
            this.inputPayTo.TabIndex = 18;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(25, 149);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(25, 13);
            this.feeLabel.TabIndex = 17;
            this.feeLabel.Text = "Fee";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(25, 79);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "Amount";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(25, 55);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 15;
            this.descriptionLabel.Text = "Description";
            // 
            // payToLabel
            // 
            this.payToLabel.AutoSize = true;
            this.payToLabel.Location = new System.Drawing.Point(25, 32);
            this.payToLabel.Name = "payToLabel";
            this.payToLabel.Size = new System.Drawing.Size(37, 13);
            this.payToLabel.TabIndex = 14;
            this.payToLabel.Text = "Pay to";
            // 
            // UserControlSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputSend);
            this.Controls.Add(this.inputPreview);
            this.Controls.Add(this.InputClear);
            this.Controls.Add(this.inputAllAvailable);
            this.Controls.Add(this.mBTCLabel);
            this.Controls.Add(this.inputFee);
            this.Controls.Add(this.inputAmount);
            this.Controls.Add(this.inputDescription);
            this.Controls.Add(this.inputPayTo);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.payToLabel);
            this.Name = "UserControlSend";
            this.Size = new System.Drawing.Size(599, 298);
            ((System.ComponentModel.ISupportInitialize)(this.inputFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputSend;
        private System.Windows.Forms.Button inputPreview;
        private System.Windows.Forms.Button InputClear;
        private System.Windows.Forms.Button inputAllAvailable;
        private System.Windows.Forms.Label mBTCLabel;
        private System.Windows.Forms.TrackBar inputFee;
        private System.Windows.Forms.TextBox inputAmount;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.TextBox inputPayTo;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label payToLabel;
    }
}

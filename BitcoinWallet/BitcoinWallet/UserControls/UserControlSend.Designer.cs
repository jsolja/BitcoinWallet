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
            this.sendButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.mBTCLabel = new System.Windows.Forms.Label();
            this.feeTrackBar = new System.Windows.Forms.TrackBar();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.payToTextBox = new System.Windows.Forms.TextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.payToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.feeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(269, 219);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 26;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(179, 219);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 25;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(86, 219);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(244, 74);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(84, 23);
            this.maxButton.TabIndex = 23;
            this.maxButton.Text = "All available";
            this.maxButton.UseVisualStyleBackColor = true;
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
            // feeTrackBar
            // 
            this.feeTrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.feeTrackBar.LargeChange = 1;
            this.feeTrackBar.Location = new System.Drawing.Point(86, 139);
            this.feeTrackBar.Maximum = 5;
            this.feeTrackBar.Minimum = 1;
            this.feeTrackBar.Name = "feeTrackBar";
            this.feeTrackBar.Size = new System.Drawing.Size(100, 45);
            this.feeTrackBar.TabIndex = 21;
            this.feeTrackBar.Value = 1;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(86, 76);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 20;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(86, 52);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(430, 20);
            this.descriptionTextBox.TabIndex = 19;
            // 
            // payToTextBox
            // 
            this.payToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payToTextBox.Location = new System.Drawing.Point(86, 29);
            this.payToTextBox.Name = "payToTextBox";
            this.payToTextBox.Size = new System.Drawing.Size(430, 20);
            this.payToTextBox.TabIndex = 18;
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
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.mBTCLabel);
            this.Controls.Add(this.feeTrackBar);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.payToTextBox);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.payToLabel);
            this.Name = "UserControlSend";
            this.Size = new System.Drawing.Size(599, 298);
            ((System.ComponentModel.ISupportInitialize)(this.feeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Label mBTCLabel;
        private System.Windows.Forms.TrackBar feeTrackBar;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox payToTextBox;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label payToLabel;
    }
}

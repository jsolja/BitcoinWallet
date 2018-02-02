namespace BitcoinWallet.Forms
{
    partial class FormWallet
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
            this.inputTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.outputBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTranstactionHistory = new System.Windows.Forms.DataGridView();
            this.Confirmations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.inputTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputTranstactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTabs
            // 
            this.inputTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTabs.Controls.Add(this.tabPage1);
            this.inputTabs.Controls.Add(this.tabPage2);
            this.inputTabs.Controls.Add(this.tabPage3);
            this.inputTabs.Controls.Add(this.tabPage4);
            this.inputTabs.Location = new System.Drawing.Point(1, 2);
            this.inputTabs.Name = "inputTabs";
            this.inputTabs.SelectedIndex = 0;
            this.inputTabs.Size = new System.Drawing.Size(579, 304);
            this.inputTabs.TabIndex = 0;
            this.inputTabs.SelectedIndexChanged += new System.EventHandler(this.inputTabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outputBalance);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.outputTranstactionHistory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // outputBalance
            // 
            this.outputBalance.AutoSize = true;
            this.outputBalance.Location = new System.Drawing.Point(87, 260);
            this.outputBalance.Name = "outputBalance";
            this.outputBalance.Size = new System.Drawing.Size(13, 13);
            this.outputBalance.TabIndex = 2;
            this.outputBalance.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance (mBTC):";
            // 
            // outputTranstactionHistory
            // 
            this.outputTranstactionHistory.AllowUserToAddRows = false;
            this.outputTranstactionHistory.AllowUserToDeleteRows = false;
            this.outputTranstactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputTranstactionHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Confirmations,
            this.Date,
            this.Description,
            this.Amount});
            this.outputTranstactionHistory.Location = new System.Drawing.Point(0, 0);
            this.outputTranstactionHistory.Name = "outputTranstactionHistory";
            this.outputTranstactionHistory.ReadOnly = true;
            this.outputTranstactionHistory.Size = new System.Drawing.Size(571, 246);
            this.outputTranstactionHistory.TabIndex = 0;
            // 
            // Confirmations
            // 
            this.Confirmations.HeaderText = "";
            this.Confirmations.Name = "Confirmations";
            this.Confirmations.ReadOnly = true;
            this.Confirmations.Width = 25;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 75;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 325;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Send";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(571, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Receive";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(571, 278);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Addresses";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FormWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 306);
            this.Controls.Add(this.inputTabs);
            this.Name = "FormWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BitcoinWallet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWallet_FormClosed);
            this.Shown += new System.EventHandler(this.FormWallet_Shown);
            this.inputTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputTranstactionHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl inputTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView outputTranstactionHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confirmations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label outputBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
    }
}
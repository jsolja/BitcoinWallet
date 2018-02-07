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
            this.outputTranstactionHistory = new System.Windows.Forms.DataGridView();
            this.Confirmations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.outputBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inputFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputNewRestoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inputQuitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputTranstactionHistory)).BeginInit();
            this.menuStrip2.SuspendLayout();
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
            this.inputTabs.Location = new System.Drawing.Point(0, 22);
            this.inputTabs.Name = "inputTabs";
            this.inputTabs.SelectedIndex = 0;
            this.inputTabs.Size = new System.Drawing.Size(843, 352);
            this.inputTabs.TabIndex = 0;
            this.inputTabs.SelectedIndexChanged += new System.EventHandler(this.inputTabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outputTranstactionHistory);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // outputTranstactionHistory
            // 
            this.outputTranstactionHistory.AllowUserToAddRows = false;
            this.outputTranstactionHistory.AllowUserToDeleteRows = false;
            this.outputTranstactionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTranstactionHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outputTranstactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputTranstactionHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Confirmations,
            this.Date,
            this.Description,
            this.Amount,
            this.Balance});
            this.outputTranstactionHistory.Location = new System.Drawing.Point(4, 6);
            this.outputTranstactionHistory.Name = "outputTranstactionHistory";
            this.outputTranstactionHistory.ReadOnly = true;
            this.outputTranstactionHistory.Size = new System.Drawing.Size(828, 317);
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
            this.Date.Width = 120;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Send";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(835, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Receive";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(835, 326);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Addresses";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // outputBalance
            // 
            this.outputBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.outputBalance.AutoSize = true;
            this.outputBalance.Location = new System.Drawing.Point(51, 389);
            this.outputBalance.Name = "outputBalance";
            this.outputBalance.Size = new System.Drawing.Size(13, 13);
            this.outputBalance.TabIndex = 2;
            this.outputBalance.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputFileMenuItem,
            this.walletToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(846, 19);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // inputFileMenuItem
            // 
            this.inputFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputNewRestoreMenuItem,
            this.toolStripSeparator1,
            this.inputQuitMenuItem});
            this.inputFileMenuItem.Name = "inputFileMenuItem";
            this.inputFileMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.inputFileMenuItem.Size = new System.Drawing.Size(27, 15);
            this.inputFileMenuItem.Text = "File";
            this.inputFileMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputNewRestoreMenuItem
            // 
            this.inputNewRestoreMenuItem.Name = "inputNewRestoreMenuItem";
            this.inputNewRestoreMenuItem.Size = new System.Drawing.Size(138, 22);
            this.inputNewRestoreMenuItem.Text = "New/Restore";
            this.inputNewRestoreMenuItem.Click += new System.EventHandler(this.inputNewRestoreMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // inputQuitMenuItem
            // 
            this.inputQuitMenuItem.Name = "inputQuitMenuItem";
            this.inputQuitMenuItem.Size = new System.Drawing.Size(138, 22);
            this.inputQuitMenuItem.Text = "Quit";
            this.inputQuitMenuItem.Click += new System.EventHandler(this.inputQuitMenuItem_Click);
            // 
            // walletToolStripMenuItem
            // 
            this.walletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordToolStripMenuItem,
            this.seedToolStripMenuItem});
            this.walletToolStripMenuItem.Name = "walletToolStripMenuItem";
            this.walletToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.walletToolStripMenuItem.Size = new System.Drawing.Size(41, 15);
            this.walletToolStripMenuItem.Text = "Wallet";
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.passwordToolStripMenuItem.Text = "Password";
            // 
            // seedToolStripMenuItem
            // 
            this.seedToolStripMenuItem.Name = "seedToolStripMenuItem";
            this.seedToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.seedToolStripMenuItem.Text = "Seed";
            // 
            // FormWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(846, 411);
            this.Controls.Add(this.outputBalance);
            this.Controls.Add(this.inputTabs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(569, 329);
            this.Name = "FormWallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BitcoinWallet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWallet_FormClosed);
            this.Shown += new System.EventHandler(this.FormWallet_Shown);
            this.inputTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputTranstactionHistory)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl inputTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView outputTranstactionHistory;
        private System.Windows.Forms.Label outputBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem inputFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputNewRestoreMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem inputQuitMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confirmations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.ToolStripMenuItem walletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seedToolStripMenuItem;
    }
}
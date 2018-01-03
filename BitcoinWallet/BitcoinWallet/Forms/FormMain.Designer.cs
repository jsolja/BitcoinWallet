namespace BitcoinWallet.Forms
{
    partial class FormMain
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
            this.inputNext = new System.Windows.Forms.Button();
            this.inputCancelOrBack = new System.Windows.Forms.Button();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNext
            // 
            this.inputNext.Location = new System.Drawing.Point(404, 364);
            this.inputNext.Name = "inputNext";
            this.inputNext.Size = new System.Drawing.Size(75, 23);
            this.inputNext.TabIndex = 0;
            this.inputNext.Text = "Next";
            this.inputNext.UseVisualStyleBackColor = true;
            this.inputNext.Click += new System.EventHandler(this.inputNext_Click);
            // 
            // inputCancelOrBack
            // 
            this.inputCancelOrBack.Location = new System.Drawing.Point(323, 364);
            this.inputCancelOrBack.Name = "inputCancelOrBack";
            this.inputCancelOrBack.Size = new System.Drawing.Size(75, 23);
            this.inputCancelOrBack.TabIndex = 6;
            this.inputCancelOrBack.Text = "Cancel";
            this.inputCancelOrBack.UseVisualStyleBackColor = true;
            this.inputCancelOrBack.Click += new System.EventHandler(this.inputCancelOrBack_Click);
            // 
            // outputPanel
            // 
            this.outputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPanel.Location = new System.Drawing.Point(75, 12);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(404, 345);
            this.outputPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BitcoinWallet.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.inputCancelOrBack);
            this.Controls.Add(this.inputNext);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BitcoinWallet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button inputNext;
        private System.Windows.Forms.Button inputCancelOrBack;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
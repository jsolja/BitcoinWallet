namespace BitcoinWallet.Class
{
    partial class UserControlKeystore
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
            this.inputPrivateKeys = new System.Windows.Forms.RadioButton();
            this.inputOwnedSeed = new System.Windows.Forms.RadioButton();
            this.inputCreateNewSeed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputPrivateKeys
            // 
            this.inputPrivateKeys.AutoSize = true;
            this.inputPrivateKeys.Location = new System.Drawing.Point(28, 108);
            this.inputPrivateKeys.Name = "inputPrivateKeys";
            this.inputPrivateKeys.Size = new System.Drawing.Size(104, 17);
            this.inputPrivateKeys.TabIndex = 7;
            this.inputPrivateKeys.Text = "Use private keys";
            this.inputPrivateKeys.UseVisualStyleBackColor = true;
            // 
            // inputOwnedSeed
            // 
            this.inputOwnedSeed.AutoSize = true;
            this.inputOwnedSeed.Location = new System.Drawing.Point(28, 85);
            this.inputOwnedSeed.Name = "inputOwnedSeed";
            this.inputOwnedSeed.Size = new System.Drawing.Size(127, 17);
            this.inputOwnedSeed.TabIndex = 6;
            this.inputOwnedSeed.Text = "I already have a seed";
            this.inputOwnedSeed.UseVisualStyleBackColor = true;
            this.inputOwnedSeed.Click += new System.EventHandler(this.inputOwnedSeed_Click);
            // 
            // inputCreateNewSeed
            // 
            this.inputCreateNewSeed.AutoSize = true;
            this.inputCreateNewSeed.Checked = true;
            this.inputCreateNewSeed.Location = new System.Drawing.Point(28, 62);
            this.inputCreateNewSeed.Name = "inputCreateNewSeed";
            this.inputCreateNewSeed.Size = new System.Drawing.Size(114, 17);
            this.inputCreateNewSeed.TabIndex = 5;
            this.inputCreateNewSeed.TabStop = true;
            this.inputCreateNewSeed.Text = "Create a new seed";
            this.inputCreateNewSeed.UseVisualStyleBackColor = true;
            this.inputCreateNewSeed.Click += new System.EventHandler(this.inputCreateNewSeed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Do you want to create a new seed, or to restore a wallet using an existing seed?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Keystore";
            // 
            // UserControlKeystore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPrivateKeys);
            this.Controls.Add(this.inputOwnedSeed);
            this.Controls.Add(this.inputCreateNewSeed);
            this.Controls.Add(this.label1);
            this.Name = "UserControlKeystore";
            this.Size = new System.Drawing.Size(495, 345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inputPrivateKeys;
        private System.Windows.Forms.RadioButton inputOwnedSeed;
        private System.Windows.Forms.RadioButton inputCreateNewSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

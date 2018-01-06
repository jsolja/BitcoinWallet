using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BitcoinWallet.Class
{
    public partial class UserControlChooseYourWallet : UserControl
    {
        public bool Availability { get; set; }
        public bool Encrypted { get; set; }
        public String FilePath
        {
            get
            {
                return inputChooseWalletText.Text;
            }
            set
            {
                inputChooseWalletText.Text = value;
            }
        }
        public String Password
        {
            get
            {
                return inputPassword.Text;
            }
            set
            {
                inputPassword.Text = value;
            }
        }

        public UserControlChooseYourWallet()
        {
            InitializeComponent();
            CheckName();
        }
        private void CheckName()
        {
            MyFile f = new MyFile();
            if(f.CheckWalletName(inputChooseWalletText.Text))
            {
                string contentOfWallet = f.ReadFile(inputChooseWalletText.Text);
                string[] seed = contentOfWallet.Split(' ');
                
                if(seed.Length != 12)
                {
                    outputFileLabel.Text = "This file is encrypted.";
                    outputLabelNext.Text = "Enter your password or choose another file.";
                    outputLabelPassword.Visible = true;
                    inputPassword.Visible = true;
                    Encrypted = true;
                }
                else
                {
                    outputFileLabel.Text = "Press 'Next' to open this file.";
                    outputLabelNext.Text = "";
                    Encrypted = false;
                }
                Availability = false;
            }
            else
            {
                outputFileLabel.Text = "This file does not exist.";
                outputLabelNext.Text = "Press 'Next' to create this wallet, or choose another file.";
                outputLabelPassword.Visible = false;
                inputPassword.Visible = false;
                Availability = true;
            }
        }
        private void inputChooseWallet_Click(object sender, EventArgs e)
        {
            MyFile file = new MyFile();
            inputChooseWalletText.Text = file.ReturnFilePath();
        }

        private void inputChooseWalletText_TextChanged(object sender, EventArgs e)
        {
            CheckName();
        }
    }
}

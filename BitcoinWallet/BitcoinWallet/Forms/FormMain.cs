using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitcoinWallet.Class;
using BitcoinWallet.UserControls;

namespace BitcoinWallet.Forms
{
    public partial class FormMain : Form
    {
        UserControlChooseYourWallet ucChooseYourWallet;
        UserControlKeystore ucKeystore;
        UserControlSeedGeneration ucSeedGeneration;
        UserControlSeedConfirmation ucSeedConfirmation;
        UserControlWalletEncryption ucWalletEncryption;
        string outputSeed;
        public FormMain()
        {
            InitializeComponent();
            ucChooseYourWallet = new UserControlChooseYourWallet();
            ucKeystore = new UserControlKeystore();
            ucSeedGeneration = new UserControlSeedGeneration();
            ucSeedConfirmation = new UserControlSeedConfirmation();
            ucWalletEncryption = new UserControlWalletEncryption();
            LoadUserControlChooseYourWallet();
        }
        private void LoadUserControlChooseYourWallet()
        {
            outputPanel.Controls.Clear();
            outputPanel.Controls.Add(ucChooseYourWallet);
            ucChooseYourWallet.Dock = DockStyle.Fill;
            ucChooseYourWallet.BringToFront();
            inputCancelOrBack.Text = "Cancel";
        }
        private void LoadUserControlKeystore()
        {
            outputPanel.Controls.Clear();
            outputPanel.Controls.Add(ucKeystore);
            ucKeystore.Dock = DockStyle.Fill;
            ucKeystore.BringToFront();
            inputCancelOrBack.Text = "Back";
        }
        private void LoadUserControlSeedGeneration()
        {
            outputPanel.Controls.Clear();
            outputPanel.Controls.Add(ucSeedGeneration);
            ucSeedGeneration.Dock = DockStyle.Fill;
            ucSeedGeneration.BringToFront();
            outputSeed = ucSeedGeneration.GetSeed;
        }
        private void LoadUserControlSeedConfirmation()
        {
            outputPanel.Controls.Clear();
            outputPanel.Controls.Add(ucSeedConfirmation);
            ucSeedConfirmation.Dock = DockStyle.Fill;
            ucSeedConfirmation.BringToFront();
        }
        private void LoadUserControlWalletEncryption()
        {
            outputPanel.Controls.Clear();
            outputPanel.Controls.Add(ucWalletEncryption);
            ucWalletEncryption.Dock = DockStyle.Fill;
            ucWalletEncryption.BringToFront();
        }
        private void LoadFormWallet()
        {
            FormWallet formWallet = new FormWallet(ucChooseYourWallet.Password, ucChooseYourWallet.FilePath);
            this.Hide();
            formWallet.ShowDialog();
        }

        private void inputNext_Click(object sender, EventArgs e)
        {
            if(outputPanel.Controls.Contains(ucChooseYourWallet))
            {
                if(ucChooseYourWallet.Availability)
                {
                    LoadUserControlKeystore();
                }
                else
                {
                    if(ucChooseYourWallet.Encrypted)
                    {
                        LoadEncryptedWallet();
                    }
                    else
                    {
                        LoadUnecryptedWallet();
                    }
                }
            }
            else if(outputPanel.Controls.Contains(ucKeystore))
            {
                LoadUserControlSeedGeneration();
            }
            else if(outputPanel.Controls.Contains(ucSeedGeneration))
            {
                LoadUserControlSeedConfirmation();
            }
            else if(outputPanel.Controls.Contains(ucSeedConfirmation))
            {
                Wallet wallet = new Wallet();
                if(wallet.ConfirmSeed(outputSeed, ucSeedConfirmation.GetSeed))
                {
                    LoadUserControlWalletEncryption();
                }
                else
                {
                    MessageBox.Show("The seed you entered is incorrect.", "BitcoinWallet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(outputPanel.Controls.Contains(ucWalletEncryption))
            {
                if(ucWalletEncryption.GetPassword == ucWalletEncryption.GetConfirmPassword)
                {
                    if(string.IsNullOrWhiteSpace(ucWalletEncryption.GetPassword))
                    {
                        FinishCreatingFile("unecrypted", ucChooseYourWallet.FilePath);
                    }
                    else
                    {
                        FinishCreatingFile("ecrypted", ucChooseYourWallet.FilePath);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match.", "BitcoinWallet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void inputCancelOrBack_Click(object sender, EventArgs e)
        {
            if(outputPanel.Controls.Contains(ucChooseYourWallet))
            {
                Application.Exit();
            }
            else if(outputPanel.Controls.Contains(ucKeystore))
            {
                LoadUserControlChooseYourWallet();
            }
            else if(outputPanel.Controls.Contains(ucSeedGeneration))
            {
                LoadUserControlKeystore();
            }
            else if(outputPanel.Controls.Contains(ucSeedConfirmation))
            {
                LoadUserControlSeedGeneration();
            }
            else if(outputPanel.Controls.Contains(ucWalletEncryption))
            {
                LoadUserControlSeedConfirmation();
            }
        }

        private void FinishCreatingFile(string encryption, string path)
        {
            MyFile f = new MyFile();
            if(encryption == "unecrypted")
            {
                f.SaveUnecryptedFile("mnemonics:"+outputSeed, path);
            }
            else
            {
                f.SaveEncryptedFile("mnemonics:"+outputSeed, ucWalletEncryption.GetPassword, path);
            }
            LoadFormWallet();
        }

        private void LoadEncryptedWallet()
        {
            if (string.IsNullOrWhiteSpace(ucChooseYourWallet.Password))
            {
                MessageBox.Show("Incorrect password.", "BitcoinWallet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Aes aes = new Aes();
                MyFile f = new MyFile();
                try
                {
                    MessageBox.Show(aes.Decrypt(f.ReadFile(ucChooseYourWallet.FilePath), ucChooseYourWallet.Password));
                    LoadFormWallet();
                }
                catch
                {
                    MessageBox.Show("Incorrect password.", "BitcoinWallet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadUnecryptedWallet()
        {
            MyFile f = new MyFile();
            MessageBox.Show(f.ReadFile(ucChooseYourWallet.FilePath));
            LoadFormWallet();
        }
    }
}

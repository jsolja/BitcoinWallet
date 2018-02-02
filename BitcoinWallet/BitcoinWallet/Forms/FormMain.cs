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
using NBitcoin;

namespace BitcoinWallet.Forms
{
    public partial class FormMain : Form
    {
        UserControlChooseYourWallet ucChooseYourWallet;
        UserControlKeystore ucKeystore;
        UserControlSeedGeneration ucSeedGeneration;
        UserControlSeedConfirmation ucSeedConfirmation;
        UserControlWalletEncryption ucWalletEncryption;
        UserControlRestore ucRestore;
        string outputSeed;
        public FormMain()
        {
            InitializeComponent();
            ucChooseYourWallet = new UserControlChooseYourWallet();
            ucKeystore = new UserControlKeystore();
            ucSeedGeneration = new UserControlSeedGeneration();
            ucSeedConfirmation = new UserControlSeedConfirmation();
            ucWalletEncryption = new UserControlWalletEncryption();
            ucRestore = new UserControlRestore();
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
        private void LoadUserControlRestore()
        {
            outputPanel.Controls.Clear();
            outputPanel.Controls.Add(ucRestore);
            ucRestore.Dock = DockStyle.Fill;
            ucRestore.BringToFront();
        }
        private void LoadFormWallet()
        {
            if(!string.IsNullOrWhiteSpace(ucChooseYourWallet.Password))
            {
                FormWallet formWallet = new FormWallet(ucChooseYourWallet.Password, ucChooseYourWallet.FilePath);
                this.Hide();
                formWallet.ShowDialog();
            }
            else if(!string.IsNullOrWhiteSpace(ucWalletEncryption.GetPassword))
            {
                FormWallet formWallet = new FormWallet(ucWalletEncryption.GetPassword, ucChooseYourWallet.FilePath);
                this.Hide();
                formWallet.ShowDialog();
            }
            else
            {
                FormWallet formWallet = new FormWallet("", ucChooseYourWallet.FilePath);
                this.Hide();
                formWallet.ShowDialog();
            }
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
                if (ucKeystore.selected == "new")
                {
                    LoadUserControlSeedGeneration();
                }
                else if (ucKeystore.selected == "restore")
                {
                    LoadUserControlRestore();
                }
            }
            else if (outputPanel.Controls.Contains(ucRestore))
            {
                bool isValidSeed = false;
                ExtKey extKey = null;
                List<BitcoinSecret> bs;
                if (ucRestore.phrase != "")
                {
                    try
                    {
                        extKey = Wallet.generateMasterAdress(ucRestore.phrase);
                        isValidSeed = true;
                    }
                    catch
                    {
                        isValidSeed = false;
                        MessageBox.Show("Seed is invalid!");
                    }
                    WalletDotDat walletDotDat = new WalletDotDat();
                    if (isValidSeed)
                    {
                        MyFile myFile = new MyFile();
                        walletDotDat.mnemonics = ucRestore.phrase;
                        bs = Wallet.Restore(extKey);
                        foreach (BitcoinSecret bits in bs)
                        {
                            walletDotDat.addPrivateKey(bits);
                        }
                        if (ucRestore.password == "")
                        {
                            myFile.SaveUnecryptedFile(walletDotDat.ToString(), ucChooseYourWallet.FilePath);
                        }
                        else
                        {
                            myFile.SaveEncryptedFile(walletDotDat.ToString(), ucRestore.password, ucChooseYourWallet.FilePath);
                        }
                        FormWallet formWallet = new FormWallet(ucRestore.password, ucChooseYourWallet.FilePath);
                        this.Hide();
                        formWallet.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Seed is invalid!");
                }

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
            else if(outputPanel.Controls.Contains(ucRestore))
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
                    aes.Decrypt(f.ReadFile(ucChooseYourWallet.FilePath), ucChooseYourWallet.Password);
                    LoadFormWallet();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Incorrect password.", "BitcoinWallet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void LoadUnecryptedWallet()
        {
            MyFile f = new MyFile();
            //MessageBox.Show(f.ReadFile(ucChooseYourWallet.FilePath));
            LoadFormWallet();
        }
    }
}

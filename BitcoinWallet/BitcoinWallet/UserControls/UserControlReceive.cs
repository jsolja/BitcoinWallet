﻿using BitcoinWallet.Class;
using NBitcoin;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ZXing;
namespace BitcoinWallet.UserControls
{
    public partial class UserControlReceive : UserControl
    {
        private BitcoinSecret bitcoinSecret;
        private BarcodeWriter barcodeWriter;
        string password, path;
        public UserControlReceive(string password, string path)
        {
            InitializeComponent();
            barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            this.password = password;
            this.path = path;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            MyFile myFile = new MyFile();
            WalletDotDat walletDotDat = new WalletDotDat();
            string text = myFile.ReadFile(path);
            string[] splitted = text.Split(' ');
            string seed;
            int i;
            if (splitted.Length != 12)
            {
                Aes aes = new Aes();
                walletDotDat.FromString(aes.Decrypt(text, password));
                seed = walletDotDat.mnemonics;
                i = walletDotDat.bitcoinSecrets.Count;
            }
            else
            {
                walletDotDat.FromString(myFile.ReadFile(path));
                seed = walletDotDat.mnemonics;
                i = walletDotDat.bitcoinSecrets.Count;
            } 
            ExtKey extKey = Wallet.generateMasterAdress(seed);

            bitcoinSecret = Wallet.generateDerivedAdress(extKey, walletDotDat.bitcoinSecrets.Count());

            inputReceiving.Text = bitcoinSecret.PubKey.GetAddress(Network.TestNet).ToString(); //
            generateQRCode();
        }
        public void generateQRCode()
        {
            string amount = inputRequestedAmount.Text;
            decimal amountD;

            if (amount == "") amountD = 0;
            else amountD = decimal.Parse(amount)/1000;

            string request =
                "bitcoin:" +
                inputReceiving.Text.ToString() +
                "?amount=" +
                amountD.ToString()+
                "&message="+
                inputDescription.Text.ToString();
            outputQRcode.Image = barcodeWriter.Write(request);

        }

        private void receivingAdressTextBox_TextChanged(object sender, EventArgs e)
        {
            generateQRCode();
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            generateQRCode();
        }

        private string previousInput = "";
        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {

            Regex r = new Regex(@"^\d*\.?\d*$|^\s$");
            Match m = r.Match(inputRequestedAmount.Text);
            if(m.Success)
            {
                previousInput = inputRequestedAmount.Text;
                generateQRCode();
            }
            else
            {
                inputRequestedAmount.Text = previousInput;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (inputReceiving.Text != "")
            {
                MyFile myFile = new MyFile();
                string text = myFile.ReadFile(path);
                string[] splitted = text.Split(' ');
                if (splitted.Length != 12)
                {
                    Aes aes = new Aes();
                    WalletDotDat walletDotDat = new WalletDotDat();
                    //aes.Decrypt(f.ReadFile(ucChooseYourWallet.FilePath), ucChooseYourWallet.Password)
                    walletDotDat.FromString(aes.Decrypt(text, password));
                    walletDotDat.addPrivateKey(bitcoinSecret);
                    MessageBox.Show(walletDotDat.ToString());
                    myFile.SaveEncryptedFile(walletDotDat.ToString(), password, path);
                }
                else
                {
                    WalletDotDat walletDotDat = new WalletDotDat();
                    walletDotDat.FromString(myFile.ReadFile(path));
                    walletDotDat.addPrivateKey(bitcoinSecret);
                    myFile.SaveUnecryptedFile(walletDotDat.ToString(),path);
                }
            }
            else
            {
                MessageBox.Show("Generate adress and input needed info!");
            }
        }
    }
}

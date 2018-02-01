using BitcoinWallet.Class;
using System;
using System.Windows.Forms;

namespace BitcoinWallet.UserControls
{
    public partial class UserControlSend : UserControl
    {
        string password, path;
        public UserControlSend(string password, string path)
        {
            InitializeComponent();
            this.password = password;
            this.path = path;
        }

        private void inputSend_Click(object sender, EventArgs e)
        {
            //remake to work with unecrypted wallet
            MyFile myFile = new MyFile();
            string text = myFile.ReadFile(path);
            WalletDotDat walletDotDat = new WalletDotDat();
            if (text.Split(' ').Length < 12)
            {
                Aes aes = new Aes();
                walletDotDat.FromString(aes.Decrypt(text, password));
            }
            else
            {
                walletDotDat.FromString(text);
            }
            BitcoinWallet.Class.Transaction transaction = new BitcoinWallet.Class.Transaction(walletDotDat.getSecrets(), 0.0005m, Decimal.Parse(inputAmount.Text), inputPayTo.Text);
            transaction.getInputs();
            try
            {
                transaction.Send();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            System.Windows.Forms.Clipboard.SetText(transaction.getHexTransaction());
            MessageBox.Show(transaction.ToString());
        }

        private void inputAllAvailable_Click(object sender, EventArgs e)
        {
            MyFile myFile = new MyFile();
            string text = myFile.ReadFile(path);
            WalletDotDat walletDotDat = new WalletDotDat();
            if (text.Split(' ').Length < 12)
            {
                Aes aes = new Aes();
                walletDotDat.FromString(aes.Decrypt(text, password));
            }
            else
            {
                walletDotDat.FromString(text);
            }
            inputAmount.Text=((Wallet.GetWalletBalance(walletDotDat.getSecrets(), true)*1000m).ToString());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputPayTo.Text = "";
            inputDescription.Text = "";
            inputAmount.Text = "";
            inputFee.Value = 1;
        }
    }
}

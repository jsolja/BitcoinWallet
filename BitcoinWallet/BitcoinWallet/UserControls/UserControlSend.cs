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
            decimal amount, fee;
            string destination=inputPayTo.Text;
            bool adressValid, amountValid, feeValid;
            DialogResult dialogResult=DialogResult.Yes;
            adressValid = Wallet.checkAdress(destination);
            amountValid = decimal.TryParse(inputAmount.Text, out amount);
            feeValid = decimal.TryParse(inputFee.Text, out fee);

            if (feeValid)fee= fee / 1000m;
            MessageBox.Show(fee.ToString());
            if (feeValid && fee < 0.0005m)
            {
                dialogResult = MessageBox.Show("Fee is too low. Confirming transaction will take very long time.", "Continue?", MessageBoxButtons.YesNo);
            }
            if (adressValid&&amountValid&&feeValid&&dialogResult==DialogResult.Yes)
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
                BitcoinWallet.Class.Transaction transaction = new BitcoinWallet.Class.Transaction(walletDotDat.getSecrets(), fee, amount, inputPayTo.Text);
                transaction.getInputs();
                try
                {
                    transaction.Send();
                }
                catch (NBitcoin.NotEnoughFundsException exc)
                {
                    decimal missing = decimal.Parse(exc.Missing.ToString())*1000m;
                    MessageBox.Show("Not enough funds. Missing: "+missing+"mBTC");
                }
                //System.Windows.Forms.Clipboard.SetText(transaction.getHexTransaction());
                MessageBox.Show(transaction.ToString());
            }
            else if (dialogResult == DialogResult.No)
            {
                inputFee.Text = "0.5";
            }
            else
            {
                string errors = "";
                if (!adressValid) errors += "Adress is not in correct format!"+Environment.NewLine;
                if (!amountValid) errors += "Amount is not in correct format!"+Environment.NewLine;
                if (!feeValid) errors += "Fee is not in correct format!" + Environment.NewLine;
                MessageBox.Show(errors);
            }
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
            inputAmount.Text=((Wallet.GetConfirmedWalletBalance(walletDotDat.getSecrets(), true)*1000m).ToString());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputPayTo.Text = "";
            inputDescription.Text = "";
            inputAmount.Text = "";
            inputFee.Text = "";
        }
    }
}

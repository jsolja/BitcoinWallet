using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitcoinWallet.Class;
using NBitcoin;

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
            Aes aes = new Aes();
            WalletDotDat walletDotDat = new WalletDotDat();
            walletDotDat.FromString(aes.Decrypt(text, password));
            BitcoinWallet.Class.Transaction transaction = new BitcoinWallet.Class.Transaction(walletDotDat.getSecrets(),0.0005m,Decimal.Parse(inputAmount.Text), "2N8hwP1WmJrFF5QWABn38y63uYLhnJYJYTF");
            transaction.getInputs();
            MessageBox.Show(transaction.ToString());
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

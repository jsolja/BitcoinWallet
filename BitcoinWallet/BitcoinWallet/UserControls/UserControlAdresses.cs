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

namespace BitcoinWallet.UserControls
{
    public partial class UserControlAdresses : UserControl
    {
        string password, path;
        public UserControlAdresses(string password, string path)
        {
            InitializeComponent();
            this.password = password;
            this.path = path;
        }

        private void UserControlAdresses_VisibleChanged(object sender, EventArgs e)
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
            dataGridView1.DataSource = walletDotDat.getAddresses();
        }

    }
}

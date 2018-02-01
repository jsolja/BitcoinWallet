using System;
using System.Windows.Forms;

namespace BitcoinWallet.UserControls
{
    public partial class UserControlWalletEncryption : UserControl
    {
        public UserControlWalletEncryption()
        {
            InitializeComponent();
        }

        public String GetPassword
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

        public String GetConfirmPassword
        {
            get
            {
                return inputConfirmPassword.Text;
            }
            set
            {
                inputConfirmPassword.Text = value;
            }
        }
    }
}

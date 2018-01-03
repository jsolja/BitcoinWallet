using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinWallet.Class
{
    public partial class UserControlSeedGeneration : UserControl
    {
        Wallet wallet;

        public String GetSeed
        {
            get
            {
                return outputSeed.Text;
            }
            set
            {
                outputSeed.Text = value;
            }
        }

        public UserControlSeedGeneration()
        {
            InitializeComponent();
            wallet = new Wallet();
            outputSeed.Text = wallet.GenerateSeed();
        }
    }
}

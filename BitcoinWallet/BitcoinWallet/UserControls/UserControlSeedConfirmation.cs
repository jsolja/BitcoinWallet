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
    public partial class UserControlSeedConfirmation : UserControl
    {
        public UserControlSeedConfirmation()
        {
            InitializeComponent();
        }

        public String GetSeed
        {
            get
            {
                return inputSeed.Text;
            }
            set
            {
                inputSeed.Text = value;
            }
        }
    }
}

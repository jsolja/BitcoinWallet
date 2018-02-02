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
    public partial class UserControlKeystore : UserControl
    {
        public string selected = "new";
        public UserControlKeystore()
        {
            InitializeComponent();
        }

        private void inputOwnedSeed_Click(object sender, EventArgs e)
        {
            selected = "restore";
        }

        private void inputCreateNewSeed_Click(object sender, EventArgs e)
        {
            selected = "new";
        }
    }
}

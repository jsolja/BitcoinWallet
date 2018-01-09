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
    public partial class UserControlSend : UserControl
    {
        public UserControlSend()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            payToTextBox.Text = "";
            descriptionTextBox.Text = "";
            amountTextBox.Text = "";
            feeTrackBar.Value = 1;
        }
    }
}

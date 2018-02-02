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
    public partial class UserControlRestore : UserControl
    {
        public string phrase = "";
        public string password = "";
        public UserControlRestore()
        {
            InitializeComponent();
        }

        private void inputPhrase_TextChanged(object sender, EventArgs e)
        {
            phrase = inputPhrase.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
        }

        private void UserControlRestore_Load(object sender, EventArgs e)
        {

        }
    }
}

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

namespace BitcoinWallet.Class
{
    public partial class UserControlChooseYourWallet : UserControl
    {
        public String FilePath
        {
            get
            {
                return inputChooseWalletText.Text;
            }
            set
            {
                inputChooseWalletText.Text = value;
            }
        }

        public UserControlChooseYourWallet()
        {
            InitializeComponent();
        }

        private void inputChooseWallet_Click(object sender, EventArgs e)
        {
            File file = new File();
            DisplayInformation(file.ReturnFilePath());
        }

        /// <summary>
        /// After choosing wallet, identify if the wallet is encrypted or not and display the information in the label. 
        /// TODO.
        /// </summary>
        private void DisplayInformation(string filePath)
        {
            inputChooseWalletText.Text = filePath;
        }
    }
}

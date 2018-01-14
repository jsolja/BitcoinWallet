using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitcoinWallet.UserControls;
namespace BitcoinWallet.Forms
{
    public partial class FormWallet : Form
    {
        string password, path;
        public FormWallet(string password, string path)
        {
            InitializeComponent();
            this.password = password;
            this.path = path;
        }

        private void FormWallet_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormWallet_Shown(object sender, EventArgs e)
        {
            UserControlSend userControlSend = new UserControlSend(password,path);
            userControlSend.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(userControlSend);
            UserControlReceive userControlReceive = new UserControlReceive(password, path);
            userControlReceive.Dock = DockStyle.Fill;
            tabPage3.Controls.Add(userControlReceive);
        }
    }
}

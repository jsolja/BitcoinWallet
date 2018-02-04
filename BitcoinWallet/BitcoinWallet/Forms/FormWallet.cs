using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitcoinWallet.Class;
using BitcoinWallet.UserControls;
using NBitcoin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitcoinWallet.Forms
{
    public partial class FormWallet : Form
    {
        string password { get; set; }
        string path { get; set; }
        private BitcoinSecret bitcoinSecret;

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

        private void GetBalance()
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
            outputBalance.Text = "Confirmed: "+((Wallet.GetConfirmedWalletBalance(walletDotDat.getSecrets(), true) * 1000m).ToString())
                                +" Unconfirmed: "+ ((Wallet.GetUnconfirmedWalletBalance(walletDotDat.getSecrets(), true) * 1000m).ToString());
        }

        private void inputTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(inputTabs.SelectedTab == inputTabs.TabPages["tabPage1"])
            {
                GetBalance();
                ShowHistory();
            }
        }

        private void FormWallet_Shown(object sender, EventArgs e)
        {
            UserControlSend userControlSend = new UserControlSend(password,path);
            userControlSend.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(userControlSend);
            UserControlReceive userControlReceive = new UserControlReceive(password, path);
            userControlReceive.Dock = DockStyle.Fill;
            tabPage3.Controls.Add(userControlReceive);
            UserControlAdresses userControlAdresses = new UserControlAdresses(password, path);
            userControlAdresses.Dock = DockStyle.Fill;
            tabPage4.Controls.Add(userControlAdresses);
            GetBalance();
            ShowHistory();
        }
        private void ShowHistory()
        {
            outputTranstactionHistory.Rows.Clear();
            MyFile myFile = new MyFile();
            WalletDotDat walletDotDat = new WalletDotDat();
            string text = myFile.ReadFile(path);
            string[] splitted = text.Split(' ');
            string seed;
            int i;
            if (splitted.Length != 12)
            {
                Aes aes = new Aes();
                walletDotDat.FromString(aes.Decrypt(text, password));
                seed = walletDotDat.mnemonics;
                i = walletDotDat.bitcoinSecrets.Count;
            }
            else
            {
                walletDotDat.FromString(myFile.ReadFile(path));
                seed = walletDotDat.mnemonics;
                i = walletDotDat.bitcoinSecrets.Count;
            }
            
            ExtKey extKey = Wallet.generateMasterAdress(seed);

            int n = 0;
            string address = "";
            for (int j = 0; j < i; j++)
            {
                bitcoinSecret = Wallet.generateDerivedAdress(extKey, j);
                address = bitcoinSecret.PubKey.GetAddress(Network.TestNet).ToString();

                using (var client = new HttpClient())
                {
                    var result = client.GetAsync("http://tapi.qbit.ninja/balances/" + address).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var content = result.Content;
                        string transactions = content.ReadAsStringAsync().Result;
                        JObject json = JObject.Parse(transactions);
                        
                        foreach (var transaction in json["operations"])
                        {
                            outputTranstactionHistory.Rows.Add();
                            if(int.Parse(transaction["confirmations"].ToString()) > 6)
                            {
                                outputTranstactionHistory.Rows[n].Cells[0].Value = "6+";
                            }
                            else
                            {
                                outputTranstactionHistory.Rows[n].Cells[0].Value = transaction["confirmations"];
                            }
                            outputTranstactionHistory.Rows[n].Cells[1].Value = transaction["firstSeen"];
                            if (int.Parse(transaction["confirmations"].ToString()) < 6)
                            {
                                outputTranstactionHistory.Rows[n].Cells[2].Value = "Unconfirmed transaction";
                            }
                            else
                            {
                                outputTranstactionHistory.Rows[n].Cells[2].Value = "Confirmed transaction";
                            }
                            outputTranstactionHistory.Rows[n].Cells[3].Value = decimal.Parse(transaction["amount"].ToString()) * 0.00000001m;
                            n++;
                        }
                    }
                }
            }
        }
    }
}

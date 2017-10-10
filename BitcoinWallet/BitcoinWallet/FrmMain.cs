using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using NBitcoin;

namespace BitcoinWallet
{
    public partial class FrmMain : Form
    {
        Mnemonic Seed { get; set; } = null;
        RijndaelManaged rijndaelManaged;
        byte[] encrypted;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void inputGenerate_Click(object sender, EventArgs e)
        {
            // ExtKey masterkey = new ExtKey();
            // outputSeed.Text = masterkey.ToString(Network.Main);

            // ExtKey masterkey = ExtKey.Parse(outputSeed.Text);
            // outputKeys.Text += "Child: " + masterkey.Derive(0).ToString(Network.Main) + Environment.NewLine;

            //Creates twelve word mnemonic (seed)
            Seed = new Mnemonic(Wordlist.English, WordCount.Twelve);
            outputSeed.Text = Seed.ToString();

            /* 
            //Creates master private key
            ExtKey masterKey = new ExtKey();
            masterKey = seed.DeriveExtKey();
            outputMasterkey.Text = masterKey.ToString(Network.Main);

            //Creates master public key
            ExtPubKey masterPubKey = masterKey.Neuter();

            outputKeys.Clear();
            //Creates 5 child private, public keys with addresses for Main Net
            for (int i = 0; i < 5; i++)
            {
                ExtKey childKey = masterKey.Derive(i, hardened: true);
                outputKeys.Text += "Private Key " + i + ": " + childKey.ToString(Network.Main) + Environment.NewLine;
                ExtPubKey childPubKey = masterPubKey.Derive((uint)i);
                outputKeys.Text += "Public key " + i + ": " + childPubKey.ToString(Network.Main) + Environment.NewLine;
                outputKeys.Text += "Address " + i + ": " + childPubKey.PubKey.GetAddress(Network.Main) + Environment.NewLine + Environment.NewLine;
            }
            */

        }

        private void inputSaveToFile_Click(object sender, EventArgs e)
        {
            if(Seed != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = ".dat|*.dat";
                sfd.Title = "wallet";
                sfd.ShowDialog();
                if(sfd.FileName != "")
                {

                    FileStream fs = (System.IO.FileStream)sfd.OpenFile();
                    byte[] data = new UTF8Encoding(true).GetBytes(Seed.ToString());
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                }
            }
            else
            {
                MessageBox.Show("ERROR: Generate a seed first.");
            }
        }


        private void inputSaveToFileEnc_Click(object sender, EventArgs e)
        {
            if (Seed != null)
            {
                rijndaelManaged = new RijndaelManaged();
                rijndaelManaged.GenerateKey();
                rijndaelManaged.GenerateIV();
                encrypted = EncryptStringToBytes(outputSeed.Text, rijndaelManaged.Key, rijndaelManaged.IV);

                outputEncSeed.Text = Encoding.UTF8.GetString(encrypted); 

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = ".dat|*.dat";
                sfd.Title = "wallet";
                sfd.ShowDialog();
                if (sfd.FileName != "")
                {
                    FileStream fs = (FileStream)sfd.OpenFile();
                    fs.Write(encrypted, 0, encrypted.Length);
                    fs.Close();
                }
                
            }
            else
            {
                MessageBox.Show("ERROR: Generate a seed first.");
            }
        }

        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encryptedText;
            using (RijndaelManaged rAlg = new RijndaelManaged())
            {
                rAlg.Key = Key;
                rAlg.IV = IV;
                ICryptoTransform encryptor = rAlg.CreateEncryptor(rAlg.Key, rAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encryptedText = msEncrypt.ToArray();
                    }
                }
            }
            return encryptedText;
        }

        private void inputDecrypt_Click(object sender, EventArgs e)
        {
            byte[] cipherText;
            Stream s = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ".dat|*.dat";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                cipherText = File.ReadAllBytes(filename);
                string decrypted = DecryptStringFromBytes(cipherText, rijndaelManaged.Key, rijndaelManaged.IV);
                outputDecSeed.Text = decrypted;
            }
        }

        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plainText;
            using (RijndaelManaged rAlg = new RijndaelManaged())
            {
                rAlg.Key = Key;
                rAlg.IV = IV;
                ICryptoTransform decryptor = rAlg.CreateDecryptor(rAlg.Key, rAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plainText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plainText;
        }
    }
}
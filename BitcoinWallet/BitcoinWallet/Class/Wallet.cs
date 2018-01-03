using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;

namespace BitcoinWallet.Class
{
    class Wallet
    {
        private Mnemonic Seed { get; set; }

        public String GenerateSeed()
        {
            Seed = new Mnemonic(Wordlist.English, WordCount.Twelve);
            return Seed.ToString();

            // ****** code below will be used for derivating private keys from master key ******

            // ExtKey masterkey = new ExtKey();
            // outputSeed.Text = masterkey.ToString(Network.Main);

            // ExtKey masterkey = ExtKey.Parse(outputSeed.Text);
            // outputKeys.Text += "Child: " + masterkey.Derive(0).ToString(Network.Main) + Environment.NewLine;

            //Creates twelve word mnemonic (seed)
            //Seed = new Mnemonic(Wordlist.English, WordCount.Twelve);
            //outputSeed.Text = Seed.ToString();

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

        public bool ConfirmSeed(string outputSeed, string inputSeed)
        {
            if(inputSeed != outputSeed)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

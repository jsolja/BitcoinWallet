using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;
namespace BitcoinWallet.Class
{
    class WalletDotDat
    {
        public List<BitcoinSecret> bitcoinSecrets = new List<BitcoinSecret>();
        public string mnemonics;
        public void FromString(string text)
        {
            string[] contents = text.Split(';');
            foreach(string content in contents)
            {
                if (content.StartsWith("adresses"))
                {
                    string[] splitted = content.Split(':');
                    string[] adresses = splitted[1].Split(',');
                    foreach(string adress in adresses)
                    {
                        BitcoinSecret bitcoinSecret = new BitcoinSecret(adress, Network.TestNet);
                        bitcoinSecrets.Add(bitcoinSecret);
                    }
                }
                else if (content.StartsWith("mnemonics"))
                {
                    string[] splitted = content.Split(':');
                    mnemonics = splitted[1];
                }
            }
        }
        public void addPrivateKey(BitcoinSecret bs)
        {
            bitcoinSecrets.Add(bs);
        }
        public BitcoinSecret[] getSecrets()
        {
            return bitcoinSecrets.ToArray();
        }
        public List<AddressValue> getAddresses()
        {
            List<AddressValue> adressValues = new List<AddressValue>();
            for(int i=0;i<bitcoinSecrets.Count;i++)
            {
                adressValues.Add(new AddressValue(bitcoinSecrets[i].GetAddress().ToString()));
            }
            return adressValues;
        }
        override
        public string ToString()
        {
            string newContent="";
            newContent += "mnemonics:" + mnemonics;
            newContent += ";";
            newContent += "adresses:";
            foreach(BitcoinSecret bitcoinSecret in bitcoinSecrets)
            {
                newContent += bitcoinSecret.PrivateKey.ToString(Network.TestNet);
                newContent += ",";
            }
            newContent = newContent.Remove(newContent.Length-1);
            return newContent;

        }
    }
    /*
    class AdressesAndTransactions{
        BitcoinSecret bitcoinSecret;

    }
    */
    public class AddressValue
    {
        public AddressValue(string adress)
        {
            _address = adress;
        }
        public string Address { get { return _address; } set { _address = value; } }
        string _address;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace BitcoinWallet.Class
{
    class Bitcoin
    {
        public static BitcoinSecret generateAdress()
        {
            return new Key().GetBitcoinSecret(Network.TestNet);
        }

        public static bool checkAdress(string publicAdress)
        {
            try
            {
                BitcoinAddress publicKey = BitcoinAddress.Create(publicAdress);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    class Transaction
    {
        private NBitcoin.Transaction transaction;
        private BitcoinSecret[] bitcoinSecrets;
        private List<BitcoinSecret> usedBitcoinSecrets = new List<BitcoinSecret>();
        private decimal fee;
        private decimal amount;
        private decimal currentAmount;
        private BitcoinAddress destination;
        public Transaction(BitcoinSecret[] bitcoinSecrets, decimal fee, decimal amount, string destination)
        {
            this.bitcoinSecrets = bitcoinSecrets;
            this.fee = fee;
            this.amount = amount/1000;
            this.destination = BitcoinAddress.Create(destination,Network.TestNet);
            this.transaction = new NBitcoin.Transaction(); 
            currentAmount = 0;
        }
        public override string ToString()
        {
            return transaction.ToString();
        }
        public void getInputs()
        {
            foreach(BitcoinSecret bs in bitcoinSecrets)
            {
                decimal adressAmount = getUnspentAmount(bs);
                if (adressAmount>0)
                {
                    usedBitcoinSecrets.Add(bs);
                    currentAmount += getUnspentAmount(bs);
                }
                if (currentAmount >= (fee + amount))
                {
                    break;
                }
            }
        }
        public decimal getUnspentAmount(BitcoinSecret privateKey)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("http://tapi.qbit.ninja/balances/" + privateKey.GetAddress() + "?unspentonly=true").Result;
                decimal amountOnAdress = 0;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string transactions = responseContent.ReadAsStringAsync().Result;
                    JObject json = JObject.Parse(transactions);
                    foreach (var transactionn in json["operations"])
                    {
                        if (transactionn["receivedCoins"].Count() != 0)
                        {
                            foreach (var transactionInfo in transactionn["receivedCoins"])
                            {
                                if (decimal.Parse(transactionInfo["value"].ToString()) * 0.00000001m > 0)
                                {
                                    TxIn input = new TxIn();
                                    var ID = transactionInfo["transactionId"].ToString();
                                    var index = transactionInfo["index"].ToString();
                                    amountOnAdress += decimal.Parse(transactionInfo["value"].ToString()) * 0.00000001m;
                                    input.PrevOut = new OutPoint(new uint256(ID), int.Parse(index));
                                    input.ScriptSig = privateKey.GetAddress().ScriptPubKey;
                                    this.transaction.Inputs.Add(input);
                                }
                            }
                        }
                    }
                    return amountOnAdress;
                }
                else
                {
                    return 0;
                }
            }
        }
        
    }
}

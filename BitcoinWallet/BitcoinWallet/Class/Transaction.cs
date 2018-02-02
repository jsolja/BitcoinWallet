using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using QBitNinja.Client;
using QBitNinja.Client.Models;
using NBitcoin.Protocol;

namespace BitcoinWallet.Class
{
    class Transaction
    {
        private NBitcoin.Transaction transaction;
        private TransactionBuilder transactionBuilder;
        private BitcoinSecret[] bitcoinSecrets;
        private List<BitcoinSecret> usedBitcoinSecrets = new List<BitcoinSecret>();
        private List<Coin> unspentCoins;
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
            this.currentAmount = 0.0M;
            this.transactionBuilder = new TransactionBuilder();
            this.unspentCoins = new List<Coin>();
        }
        public override string ToString()
        {
            return transaction.ToString();
        }
        
        public void getInputs()
        {
            decimal oldCurrentAmount = 0;
            foreach(BitcoinSecret bs in bitcoinSecrets)
            {
                oldCurrentAmount = currentAmount;
                List<Coin> newCoins =getInputs(bs, ref this.currentAmount);
                //currentAmount += newCoins.Sum(x => x.Amount.ToDecimal(MoneyUnit.BTC));
                if (oldCurrentAmount!=currentAmount)
                {
                    unspentCoins.AddRange(newCoins);
                    usedBitcoinSecrets.Add(bs);
                }
                if (currentAmount >= (fee + amount))
                {
                    break;
                }
            }
        }
        public string getHexTransaction()
        {
            return transaction.ToHex();
        }
        private List<Coin> getInputs(BitcoinSecret bitcoinSecret, ref decimal current)
        {
            string bitcoinAddress = bitcoinSecret.GetAddress().ToString();
            QBitNinjaClient client = new QBitNinjaClient(Network.TestNet);
            var balance = client.GetBalance(new BitcoinPubKeyAddress(bitcoinAddress), true).Result;
            var unspentCoins = new List<Coin>();
            if (balance.Operations.Count > 0)
            {
                foreach (var operation in balance.Operations)
                {
                    if (operation.Confirmations > 5)
                    {
                        unspentCoins.AddRange(operation.ReceivedCoins.Select(coin => coin as Coin));
                    }
                }
                current += unspentCoins.Sum(x => x.Amount.ToDecimal(MoneyUnit.BTC));
            }
            return unspentCoins;
        }
        public void Send()
        {
            //later set bitcoin change on new derived adress!
            string amount = this.amount.ToString();
            string fee = this.fee.ToString();
            transaction = transactionBuilder.AddKeys(bitcoinSecrets)
                                            .AddCoins(unspentCoins)
                                            .Send(destination, amount)
                                            .SetChange(bitcoinSecrets[0].GetAddress())
                                            .SendFees(fee)
                                            .BuildTransaction(true);

            QBitNinjaClient client = new QBitNinjaClient(Network.TestNet);
            BroadcastResponse broadcastResponse = client.Broadcast(transaction).Result;
        }
    }
}

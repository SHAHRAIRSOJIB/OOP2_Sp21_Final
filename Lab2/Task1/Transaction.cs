using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Transaction
    {

        public Account Sender { get; set; }

        public Account Receiver { get; set; }

        public double Amount { get; set; }

        public string AdditionalInfo { get; set; }

        public Transaction() { }

        public Transaction(Account sender, Account receiver, double amount, string additionalInfo)
        {
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
            AdditionalInfo = additionalInfo;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Send by: ", this.Sender.AccountName);
            Console.WriteLine("Received by:  ",this.Receiver.AccountName);
            Console.WriteLine("Amount: ", Amount);
        }
    }
}

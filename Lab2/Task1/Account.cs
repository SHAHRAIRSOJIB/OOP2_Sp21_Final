using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
  
    class Account
    {
        private Transaction[] listOfTransaction;

        public string AccountName { get; set; }

        public string AccountNo { set; get; }

        public double Balance { get; set; }

        public int TotalNumberOfTransaction { set; get; }

        public Account()
        {
            listOfTransaction = new Transaction[50];
        }

        public Account(string accountName, string accountNo, double balance)
        {
            AccountName = accountName;
            AccountNo = accountNo;
            Balance = balance;
            listOfTransaction = new Transaction[50];
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Transaction t1 = new Transaction(this, this, amount, "Self Deposit");
            AddTransaction(t1);
        }

        public void AddTransaction(Transaction t1)
        {
            if (TotalNumberOfTransaction < 10)
            {
                listOfTransaction[TotalNumberOfTransaction++] = t1;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Name: {0}", AccountName);
            Console.WriteLine("Acc ount No: {0}", AccountNo);
            Console.WriteLine("Balance: {0}", Balance);
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                Transaction t = new Transaction(this, this, amount, "Self Withdraw");
                AddTransaction(t);
            }
            else
            {
                Console.WriteLine("Insufficient");
            }
        }

        public void Transfer(Account acc, double amount)
        {
            if (Balance - amount >= 0)
            {
                Transaction t1 = new Transaction(this, acc, amount, "Transfer");
                acc.Balance += amount;
                acc.AddTransaction(t1);

                
                Balance -= amount;
                AddTransaction(t1);
            }
            else
            {
                Console.WriteLine("Insufficien Balance!!");
            }
        }

        public void ShowAllTransaction()
        {
            for (int i = 0; i < TotalNumberOfTransaction; ++i )
            {
                listOfTransaction[i].ShowInfo();
            }
        }
    }
}

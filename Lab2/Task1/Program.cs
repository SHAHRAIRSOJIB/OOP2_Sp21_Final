using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
             Account acc1 = new Account("Munem", "M101", 5000);
             Account acc2 = new Account("Shahrair", "S001", 1500);
             Account acc3 = new Account("Sojib", "Sh109", 100);

            acc1.Deposit(10000);
            acc1.Withdraw(9000);
            acc1.Transfer(acc2, 2500);

            Console.WriteLine("Balance");

            acc1.ShowInfo();
            acc2.ShowInfo();

            Console.WriteLine(" Transactions ");

            acc1.ShowAllTransaction();
            acc2.ShowAllTransaction();
            acc3.ShowAllTransaction();
        }
    }
}

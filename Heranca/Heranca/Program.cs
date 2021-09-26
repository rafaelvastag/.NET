using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new BusinessAccount(8010, "Rafael", 10000.0, 500.0);
            Account acc2 = new SavingsAccount(8010, "Rafael", 10000.0, 2.0);

            if (account is BusinessAccount)
            {
                BusinessAccount acc3 = account as BusinessAccount;
                acc3.Loan(2000.0);
                Console.WriteLine(acc3.ToString());
            }
            account.WithDraw(10.0);
            acc2.WithDraw(10.0);
            Console.WriteLine(account.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}

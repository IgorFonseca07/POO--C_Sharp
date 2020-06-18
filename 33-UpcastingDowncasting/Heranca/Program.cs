using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING:

            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account account3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING:

            // BusinessAccount businessAccount1 = account2;   --> //Are u missing a cast?
            BusinessAccount businessAccount2 = (BusinessAccount)account2;
            businessAccount2.Loan(100.0);
            // account2.Loan(100.0);    --> //compilador não sabe que é um BusinessAccount


            //BusinessAccount businessAccount3 = (BusinessAccount)account3; -->  //apesar de não aparentar erro, na hora da execução
                                                                                 //verá o erro. subclasse para subclasse

            //BusinessAccount businessAccount3 = (BusinessAccount)account3;
            if (account3 is BusinessAccount)
            {
                // BusinessAccount businessAccount3 = (BusinessAccount)account3;
                BusinessAccount businessAccount3 = account3 as BusinessAccount; // outra forma de fazer o cast!
                businessAccount3.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (account3 is SavingsAccount)
            {
                // SavingsAccount savingsAccount = (SavingsAccount)account3;
                SavingsAccount savingsAccount = account3 as SavingsAccount; // outra forma de fazer o cast!
                savingsAccount.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}

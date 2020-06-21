using System;
using System.Collections.Generic;
using System.Globalization;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0); //Não se pode mais instanciar Account por causa do abstract
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();


            List<Account> accounts = new List<Account>();  //Porém ainda se pode instanciar uma lista da classe

            accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));      //Instanciando somente suas subclasses
            accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));   //dentro da lista
            accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            double sum2 = 0.0;

            foreach (Account account in accounts)       //Porém a lista não deixa de ser uma lista de Account
            {
                sum += account.Balance;
                account.Withdraw(10.0);
                sum2 += account.Balance;
            }

            foreach (Account account in accounts)
            {
                Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture)
                    + " and "
                    + sum2.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

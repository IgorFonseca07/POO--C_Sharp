using Exerc17.Entities.Exceptions;

namespace Exerc17.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double deposit)
        {
            Balance += deposit;
        }

        public void Withdraw(double withdraw)
        {
            if (withdraw > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit!");
            }
            if (withdraw > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance!");
            }
            Balance -= withdraw;
        }


    }
}

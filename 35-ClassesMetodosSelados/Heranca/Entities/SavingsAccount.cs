namespace Heranca.Entities
{
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)     // Método selado! sealed
        {
            Balance -= amount;
        }

        //public override void Withdraw(double amount)       *Nesse caso aqui, você aproveitaria o método Withdraw da
        //{                                                  *superclasse e descontaria mais 2 reais
        //    base.Withdraw(amount);
        //    Balance -= 2.0;    
        //}
    }
}

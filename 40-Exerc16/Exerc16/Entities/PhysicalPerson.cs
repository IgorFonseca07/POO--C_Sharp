namespace Exerc16.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public PhysicalPerson()
        {
        }

        public PhysicalPerson(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            if (AnualIncome < 20000.00)
            {
                if (HealthExpenditures > 0.00)
                {
                    return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
                }
                else
                {
                    return AnualIncome * 0.15;
                }
            }
            else
            {
                if (HealthExpenditures > 0.00)
                {
                    return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
                }
                else
                {
                    return AnualIncome * 0.25;
                }
            }
        }
    }
}

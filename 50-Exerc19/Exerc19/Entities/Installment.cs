using System;
using System.Globalization;

namespace Exerc19.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.Date + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

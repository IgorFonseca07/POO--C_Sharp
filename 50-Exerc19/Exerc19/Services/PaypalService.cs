using System;
using Exerc19.Entities;

namespace Exerc19.Services
{
    class PaypalService : ICompanies
    {

        public void Taxs(PaymentService paymentService, double installmentValue)
        {
            for (int i = 1; i <= paymentService.NumberOfInstallments; i++)
            {
                double amount = installmentValue + (installmentValue * (0.01 * i));
                amount += (amount * 0.02);

                DateTime dueDate = paymentService.Contract.Date.AddMonths(i);

                paymentService.Installments.Add(new Installment(dueDate, amount));
            }
        }

    }
}

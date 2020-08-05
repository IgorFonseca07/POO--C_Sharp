using System;
using Exerc19.Entities;

namespace Exerc19.Services
{
    class PaypalService : Companies
    {

        public void Taxs(PaymentService paymentService)
        {
            for (int i = 1; i <= paymentService.NumberOfInstallments; i++)
            {
                double amount = (paymentService.Contract.TotalValue * (0.01 * i));
                amount += (amount * 0.02);

                DateTime dueDate = paymentService.Contract.Date.AddDays(30 * i);

                paymentService.Installments.Add(new Installment(dueDate, amount));
            }
        }

    }
}

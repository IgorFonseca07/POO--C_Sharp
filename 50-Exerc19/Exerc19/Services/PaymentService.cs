using Exerc19.Entities;
using System.Collections.Generic;

namespace Exerc19.Services
{
    class PaymentService
    {
        public int NumberOfInstallments { get; set; }
        public Contract Contract { get; set; }
        public List<Installment> Installments { get; set; }
        private Companies Companies;

        public PaymentService(int numberOfInstallments, Contract contract, Companies companies)
        {
            NumberOfInstallments = numberOfInstallments;
            Contract = contract;
            Companies = companies;
        }

        public void Payment(PaymentService paymentService)
        {
            Companies.Taxs(paymentService);
        }


    }
}

using Exerc19.Entities;
using System.Collections.Generic;

namespace Exerc19.Services
{
    class PaymentService
    {
        public int NumberOfInstallments { get; set; }
        public Contract Contract { get; set; }
        public List<Installment> Installments = new List<Installment>();
        private ICompanies Companies;

        public PaymentService(int numberOfInstallments, Contract contract, ICompanies companies)
        {
            NumberOfInstallments = numberOfInstallments;
            Contract = contract;
            Companies = companies;
        }

        public void Payment(PaymentService paymentService)
        {
            double installmentValue = paymentService.Contract.TotalValue / paymentService.NumberOfInstallments;

            Companies.Taxs(paymentService, installmentValue);
        }


    }
}

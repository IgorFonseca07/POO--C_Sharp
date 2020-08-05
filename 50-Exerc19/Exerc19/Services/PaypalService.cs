namespace Exerc19.Services
{
    class PaypalService : Companies
    {

        public void Taxs(PaymentService paymentService)
        {
            for (int i = 1; i <= paymentService.NumberOfInstallments; i++)
            {

            }
        }

    }
}

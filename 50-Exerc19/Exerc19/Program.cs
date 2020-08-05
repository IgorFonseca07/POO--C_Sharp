using Exerc19.Entities;
using Exerc19.Services;
using System;
using System.Globalization;

namespace Exerc19
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);
            PaymentService paymentService = new PaymentService(numberOfInstallments, contract, new PaypalService());

            paymentService.Payment(paymentService);
            
            Console.WriteLine("Installments:");
            foreach (Installment installment in paymentService.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}

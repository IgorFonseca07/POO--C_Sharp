using Exerc16.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exerc16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> taxpayers = new List<Person>();

            Console.Write("Enter the number of taxpayers: ");
            int quantityTaxpayers = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= quantityTaxpayers; i++)
            {
                Console.WriteLine("Taxpayer #" + i + " data:");
                Console.Write("Individual or company (i/c)? ");
                string ic = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ic == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxpayers.Add(new PhysicalPerson(name, anualIncome, healthExpenditures));
                }
                else if (ic == "c")
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxpayers.Add(new LegalPerson(name, anualIncome, numberOfEmployees));
                }
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");
            double sum = 0.00;
            foreach (Person person in taxpayers)
            {
                Console.WriteLine(person.Name
                    + ": $ "
                    + person.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                sum += person.Taxes();
            }
            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}

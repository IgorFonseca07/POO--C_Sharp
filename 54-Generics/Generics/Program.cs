using Generics.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>(); //Nesse caso aqui, escolhi string

            PrintService<int> printService2 = new PrintService<int>(); //Nesse caso posso usar tudo lá porém agora em int

            Console.Write("How many values: ");
            int quantityValues = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantityValues; i++)
            {
                string value = Console.ReadLine();
                printService.AddValue(value);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] namePrice = Console.ReadLine().Split(',');
                list.Add(new Product(namePrice[0], double.Parse(namePrice[1], CultureInfo.InvariantCulture)));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list); //Precisou definir o IComparable na classe Product para que o
                                                        //programa soubesse qual atributo lá dentro comparar
            Console.WriteLine("Max:");
            Console.WriteLine(max);

        }
    }
}

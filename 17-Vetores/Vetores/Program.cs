using System;
using System.Globalization;

namespace Vetores {
    class Program {
        static void Main(string[] args) {


            // Vetor eu já sabia do Javascript

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            double sum = 0.00;
            

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vect[i];
            }

            Console.WriteLine(sum);

            double media = sum / (vect.Length);

            Console.WriteLine(media);


            Console.WriteLine();
            //----------------------------------------------------------------------------------
            Console.WriteLine();


            // Exercício exemplo:

            int numeroprodutos = int.Parse(Console.ReadLine());

            Product[] vetor = new Product[n];
            double soma = 0.00;

            for (int i = 0; i < numeroprodutos; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Product { Nome = name, Preco = price };
                soma += vetor[i].Preco;
            }

            double average = soma / (vetor.Length);

            Console.WriteLine("AVERAGE PRICE = " + average.ToString("F2", CultureInfo.InvariantCulture));

            

        }
    }
}

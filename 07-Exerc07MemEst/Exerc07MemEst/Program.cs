using System;
using System.Globalization;

namespace Exerc07MemEst {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double cotdolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double comdolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pagreais = ConversorDeMoeda.PagarEmReais(cotdolar, comdolar);

            Console.WriteLine("Valor a ser pago em reais = " + pagreais.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

using System;
using System.Globalization;

namespace Exerc08 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com o número da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titularconta = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (S/N) ");
            string depositoinicial = Console.ReadLine();
            double movimentacao = 0.00;

            if (depositoinicial == "S") {
                Console.Write("Entre com o valor de depósito inicial: ");
                movimentacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }                        

            Conta n1 = new Conta(numeroconta, titularconta, movimentacao);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(n1);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            movimentacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n1.Deposito(movimentacao);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(n1);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            movimentacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n1.Saque(movimentacao);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(n1);




        }
    }
}

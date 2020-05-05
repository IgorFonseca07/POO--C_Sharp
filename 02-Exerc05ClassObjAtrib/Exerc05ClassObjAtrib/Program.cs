using System;
using System.Globalization;

namespace Exerc05ClassObjAtrib {
    class Program {
        static void Main(string[] args) {

            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade) {
                Console.WriteLine("Pessoa mais velha: " + x.Nome);
            }
            else if (x.Idade < y.Idade) {
                Console.WriteLine("Pessoa mais velha: " + y.Nome);
            }
            else {
                Console.WriteLine("Possuem a mesma idade!");
            }

            
            Console.WriteLine("-----------------------------------");


            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.Salario + b.Salario) / 2;

            Console.WriteLine("Salário Médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

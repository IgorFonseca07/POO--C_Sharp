using System;
using System.Globalization;

namespace Exerc06ClassAtribMet {
    class Program {
        static void Main(string[] args) {

            
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("ÁREA: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();

            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porc);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();

            Aluno a = new Aluno();
            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (a.NotaFinal() >= 60.00) {
                Console.WriteLine("APROVADO!");
            }
            else {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM " + a.Faltaram().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }


        }
    }
}

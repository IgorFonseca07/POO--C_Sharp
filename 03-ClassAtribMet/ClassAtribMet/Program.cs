using System;
using System.Globalization;

namespace ClassAtribMet {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área Triângulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área Triângulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Área do Triângulo X é maior!");
            }
            else if (areaY > areaX) {
                Console.WriteLine("Área do Triângulo Y é maior!");
            }
            else {
                Console.WriteLine("Triângulos possuem mesmo valor de área!");
            }


            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(" ");

            
            Produto z = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            z.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            z.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            z.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + z);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantad = int.Parse(Console.ReadLine());
            z.AdicionarProdutos(quantad);
            Console.WriteLine("Dados atualizados: " + z);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int quantrem = int.Parse(Console.ReadLine());
            z.RemoverProdutos(quantrem);
            Console.WriteLine("Dados atualizados: " + z);
            

        }
    }
}

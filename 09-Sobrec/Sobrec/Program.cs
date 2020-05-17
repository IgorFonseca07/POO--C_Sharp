using System;
using System.Globalization;

namespace Sobrec {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nom = Console.ReadLine();
            Console.Write("Preço: ");
            double prec = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            

            Produto p = new Produto(nom, prec);

            Produto x = new Produto(nom, prec, 15);

            Produto y = new Produto();


            /*Sintaxe alternativa para inicializar valores: */
            Produto p2 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };
            /*Não precisa ter construtores para esse último exemplo! */


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}

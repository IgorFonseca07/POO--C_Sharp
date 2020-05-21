using System;
using System.Globalization;

namespace Prop {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";
            p.RemoverProdutos(5);
            p.AdicionarProdutos(3);

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

        }
    }
}
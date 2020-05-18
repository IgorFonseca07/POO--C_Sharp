using System;
using System.Globalization;

namespace Encaps {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T");
            p.RemoverProdutos(5);
            p.AdicionarProdutos(3);

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());

        }
    }
}

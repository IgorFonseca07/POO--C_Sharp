using Comparacao_Igualdade_Colecoes_Hash.Entities;
using System;
using System.Collections.Generic;

namespace Comparacao_Igualdade_Colecoes_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> hsa = new HashSet<Product>(); // Class -> Tipo Referência
            hsa.Add(new Product("TV", 900.0));
            hsa.Add(new Product("Notebook", 1200.0));

            HashSet<Point> hsb = new HashSet<Point>(); // Struct -> Tipo Valor
            hsb.Add(new Point(3, 4));
            hsb.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(hsa.Contains(prod)); // Dará False pois o endereço de memória é diferente (Tipo Referência)
                                                   // Para dar True precisa-se implantar o GetHashCode e o Equals na class
            Console.WriteLine("----------");

            Point p = new Point(5, 10);
            Console.WriteLine(hsb.Contains(p));    // Dará True pois o tipo struct é Valor, então vai comparar o conteúdo
        }
    }
}

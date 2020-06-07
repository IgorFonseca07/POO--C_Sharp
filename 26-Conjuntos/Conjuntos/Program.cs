using System;
using System.Collections.Generic;

namespace Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(9);
            B.Add(3);
            B.Add(4);
            B.Add(5);
            // NÃO ACEITA REPETIÇÕES, o valor 4 não irá entrar novamente no Conjunto:
            B.Add(4);

            B.Remove(9);

            foreach (int x in B) {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");

            A.ExceptWith(B);

            foreach (int x in A) {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");

            A.UnionWith(B);

            foreach (int x in A) {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");

            A.IntersectWith(B);

            foreach (int x in A) {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------");

            Console.Write("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N)) {
                Console.WriteLine(N + " pertence ao conjunto B!");
            }
            else {
                Console.WriteLine(N + " não pertence ao conjunto B!");
            }

        }
    }
}

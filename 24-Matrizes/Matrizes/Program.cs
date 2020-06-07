using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {


            double[,] ex = new double[2, 3];

            Console.WriteLine(ex.Length);

            Console.WriteLine(ex.Rank);

            Console.WriteLine(ex.GetLength(0));

            Console.WriteLine(ex.GetLength(1));

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();


            Console.Write("Entre com o valor N da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrixn = new int[n, n];
            int[] diagonal = new int[n];
            int sumnegatives = 0;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Entre com o valor da linha " + i + ", coluna " + j + ": ");
                    matrixn[i, j] = int.Parse(Console.ReadLine());
                    if (i == j) {
                        diagonal[i] = matrixn[i, j];
                    }
                    if (matrixn[i, j] < 0) {
                        sumnegatives++;
                    }
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(diagonal[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Negative Numbers = " + sumnegatives);



        }
    }
}

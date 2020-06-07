using System;

namespace Exerc11 {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many rows the matrix will be? ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("How many columns the matrix will be? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] matrixmn = new int[m, n];

            for (int i = 0; i < m; i++) {
                for (int j = 0; i < n; i++) {
                    Console.Write("Number row " + m + " column " + n + ": ");
                    matrixmn[m, n] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.Write("What's the number X? ");
            int numberx = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; i < n; i++) {
                    if (matrixmn[m, n] == numberx) {
                        Console.WriteLine("Position " + m + "," + n + ":");

                    }
                }
            }

        }
    }
}

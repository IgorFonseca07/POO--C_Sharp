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
                for (int j = 0; j < n; j++) {
                    Console.Write("Number row " + i + " column " + j + ": ");
                    matrixmn[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.Write("What's the number X? ");
            int numberx = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (matrixmn[i, j] == numberx) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        
                    }
                }
            }

        }
    }
}

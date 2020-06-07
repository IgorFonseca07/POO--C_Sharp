using System;
using System.Collections.Generic;

namespace Exerc12 {
    class Program {
        static void Main(string[] args) {

            HashSet<int> CursoA = new HashSet<int>();
            HashSet<int> CursoB = new HashSet<int>();
            HashSet<int> CursoC = new HashSet<int>();

            int contadoralunos = 0;

            Console.Write("O curso A possui quantos alunos? ");
            int quantalunosa = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < quantalunosa; i++) {
                CursoA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            int quantalunosb = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < quantalunosb; i++) {
                CursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            int quantalunosc = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < quantalunosc; i++) {
                CursoC.Add(int.Parse(Console.ReadLine()));
            }            

            CursoA.UnionWith(CursoB);            
            CursoA.UnionWith(CursoC);

            foreach (int x in CursoA) {               
                contadoralunos++;
            }

            Console.WriteLine("Total de alunos: " + contadoralunos);

        }
    }
}

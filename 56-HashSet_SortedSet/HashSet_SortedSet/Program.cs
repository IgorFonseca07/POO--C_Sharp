using System;
using System.Collections.Generic;

namespace HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vs = new HashSet<string>();

            vs.Add("oi");
            vs.Add("oi");
            vs.Add("hello");

            Console.WriteLine(vs.Contains("oi"));
            Console.WriteLine(vs.Contains("olá"));

            Console.WriteLine("-------------------------");

            foreach (string s in vs)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("ou usando o PrintColection:");

            PrintCollection(vs); //Não existe uma ordem exata dos dados jogados dentro do HashSet, quase uma ordem de "chegada"


            Console.WriteLine("-------------------------------------------");


            SortedSet<int> ssa = new SortedSet<int>() { 10, 2, 4, 5, 6, 8, 0 };
            SortedSet<int> ssb = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(ssa); //Repare que o SortedSet sempre deixa em ordem, diferente do HashSet

            Console.WriteLine("-------------------------");

            // Union:
            SortedSet<int> ssc = new SortedSet<int>(ssa); //ssc acabou de se tornar uma cópia de ssa
            ssc.UnionWith(ssb);
            PrintCollection(ssc); //HashSet e SortedSet não aceita repetições, então os uniu sem valores repetidos

            Console.WriteLine("-------------------------");

            // Intersection:
            SortedSet<int> ssd = new SortedSet<int>(ssa);
            ssd.IntersectWith(ssb);
            PrintCollection(ssd); //São os elementos em ssa que existem em ambas as coleções, ou seja, que existem tb em ssb!

            Console.WriteLine("-------------------------");

            // Difference (ExceptWith)
            SortedSet<int> sse = new SortedSet<int>(ssa);
            sse.ExceptWith(ssb);
            PrintCollection(sse); //Elementos em ssa que não existem em ssb
        }

        static void PrintCollection<T>(IEnumerable<T> colection) //IEnumerable - generico para Lists, HashSets, SortedSets, etc
        {
            foreach(T obj in colection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}

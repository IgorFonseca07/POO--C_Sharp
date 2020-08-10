using System;
using System.Collections.Generic;

namespace Exerc21
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> students = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int studentsA = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsA; i++)
            {
                int studentsCode = int.Parse(Console.ReadLine());
                students.Add(studentsCode);
            }

            Console.Write("How many students for course B? ");
            int studentsB = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsB; i++)
            {
                int studentsCode = int.Parse(Console.ReadLine());
                students.Add(studentsCode);
            }

            Console.Write("How many students for course C? ");
            int studentsC = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsC; i++)
            {
                int studentsCode = int.Parse(Console.ReadLine());
                students.Add(studentsCode);
            }

            Console.WriteLine("Total students: " + students.Count);
        }
    }
}

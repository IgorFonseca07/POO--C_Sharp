using IComparable_.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace IComparable_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Caveira\Documents\CursoC#_Udemy\POO--C_Sharp\53-IComparable\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); //CompareTo definiu para a função Sort() qual seria a referencia para ordenação, Name ou Salary
                    foreach (Employee employee in list)
                    {
                        Console.WriteLine(employee);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}

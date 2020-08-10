using System;
using System.Collections.Generic;
using System.IO;

namespace Exerc20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            HashSet<string> names = new HashSet<string>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);

                        string[] lines = line.Split(' ');
                        names.Add(lines[0]);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred:" + e.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Total users: " + names.Count);
        }
    }
}
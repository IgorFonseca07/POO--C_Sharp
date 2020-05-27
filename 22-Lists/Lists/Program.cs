using System;
using System.Collections.Generic;

namespace Lists {
    class Program {
        static void Main(string[] args) {

            //Exemplos:

            List<string> ex = new List<string>();
            List<string> ex2 = new List<string> { "Igor", "Fran", "João" };

            //---------------------------------------------------------------

            List<string> list = new List<string>();

            list.Add("Maria");                   //Add
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");             //Insert
            list.Add("Igor");
            list.Add("Vergo");
            list.Add("Luffy");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count: " + list.Count);                               //Count

            string s1 = list.Find(x => x[0] == 'A');                                      //Finds
            Console.WriteLine("First beginning with A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last beginning with A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position name beginning with A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position name beginning with A: " + pos2);

            Console.WriteLine("-------------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------");                         
            list.Remove("Marco");                                                         //Removes
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------");

            list.RemoveAt(1);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------");

            list.RemoveRange(2, 2);
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }





        }
    }
}

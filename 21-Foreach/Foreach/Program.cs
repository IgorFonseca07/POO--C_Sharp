using System;

namespace Foreach {
    class Program {
        static void Main(string[] args) {


            //Muitas vezes usado mais que o For:


            string[] names = new string[] { "Maria", "Alex", "Bob" };

            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("------------------------------------------");

            foreach (string thenames in names) {
                Console.WriteLine(thenames);
            }
        }
    }
}

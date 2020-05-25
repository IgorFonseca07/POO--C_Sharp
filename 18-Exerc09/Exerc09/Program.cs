using System;

namespace Exerc09 {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many rooms will be rented? ");
            int roomsrented = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Rooms[] vect = new Rooms[10];

            for (int i = 1; i <= roomsrented; i++) {
                Console.WriteLine("Rent #" + i + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Rooms { Name = name, Email = email };
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i <= 9; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }               
            }


        }
    }
}

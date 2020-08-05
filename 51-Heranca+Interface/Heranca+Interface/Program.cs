using Heranca_Interface.Model.Entities;
using Heranca_Interface.Model.Enums;
using System;

namespace Heranca_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle(2.00, Color.White);
            IShape s2 = new Rectangle(3.50, 4.20, Color.Black);

            Console.WriteLine(s1);
            Console.WriteLine();
            Console.WriteLine(s2);
            Console.WriteLine();
        }
    }
}

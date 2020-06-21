using System;
using Exerc15.Entities;
using Exerc15.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace Exerc15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int quantityShapes = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= quantityShapes; i++)
            {
                Console.WriteLine("Shape #" + i + " data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                string rc = Console.ReadLine();
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (rc == "r")
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(color, width, height));
                }
                else if (rc == "c")
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine();

            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}

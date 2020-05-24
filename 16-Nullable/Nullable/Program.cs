using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {

            Nullable<double> x = null;


            // O jeito mais fácil:
            double? y = null;
            double? z = 10.00;

            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(z.GetValueOrDefault());

            Console.WriteLine();

            Console.WriteLine(y.HasValue);
            Console.WriteLine(z.HasValue);

            Console.WriteLine();

            if (y.HasValue) {
                Console.WriteLine(y.Value);                
            }
            else {
                Console.WriteLine("Y is null");
            }

            if (z.HasValue) {
                Console.WriteLine(z.Value);
            }
            else {
                Console.WriteLine("Z is null");
            }


            Console.WriteLine();
            //-----------------------------------------------------------------
            Console.WriteLine();


            //Operador de coalescência nula:

            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}

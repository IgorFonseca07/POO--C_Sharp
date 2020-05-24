using System;

namespace TiposRefer_TiposValor {
    class Program {
        static void Main(string[] args) {

            Point p;

            p.X = 20;
            p.Y = 10;

            Console.WriteLine(p);


            // ou pode-se inicializar assim:

            Point m = new Point();

            Console.WriteLine(m);


            // Caso houver um construtor:

            Point n = new Point(40, 50);

            Console.WriteLine(n);

        }
    }
}

using System;

namespace BoxingUnboxing {
    class Program {
        static void Main(string[] args) {

            //Boxing: Processo de conversão objeto tipo Valor para objeto tipo Referência compatível:

            int x = 20;
            Object obj = x;

            Console.WriteLine(x);
            Console.WriteLine(obj);


            //Unboxing: Processo de conversão objeto tipo Referência para objeto tipo Valor compatível:

            int y = (int)obj;

            Console.WriteLine(y);


        }
    }
}

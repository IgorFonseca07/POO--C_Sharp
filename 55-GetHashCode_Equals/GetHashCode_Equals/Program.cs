using System;

namespace GetHashCode_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Igor";
            string b = "Fran";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.WriteLine("------------------");

            b = "Igor";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            /*
                - Equals sempre retornará a resposta 100% confiável, porém demora a resposta!

                - Mais rápido o retorno, mas se o GetHashCode retornar códigos diferentes, então você pode ter certeza
                que os dois objetos são diferentes, porém caso retorne códigos iguais inda existe uma possibilidade de os
                objetos também serem diferentes e, em caso de fazer uma comparação em larga escala, use o GetHashCode
                primeiro e depois use o Equals naqueles que obtiveram códigos iguais.
            */

        }
    }
}

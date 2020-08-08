using GetHashCode_Equals.Entities;
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

            Console.WriteLine("------------------");

            // -> Caso não faça construtores na classe, pode-se instanciar desta forma abaixo:
            /*
            Client client01 = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client client02 = new Client { Name = "Alex", Email = "alex@gmail.com" };
            */

            Client client01 = new Client("Maria", "maria@gmail.com");
            Client client02 = new Client("Alex", "maria@gmail.com");

            Console.WriteLine(client01.Equals(client02));
            Console.WriteLine(client01 == client02);
            Console.WriteLine(client01.GetHashCode());
            Console.WriteLine(client02.GetHashCode());
        }
    }
}

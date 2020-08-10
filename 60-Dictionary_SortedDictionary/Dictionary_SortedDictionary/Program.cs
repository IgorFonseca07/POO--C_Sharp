using System;
using System.Collections.Generic;

namespace Dictionary_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();   // <Key, Value>

            cookies.Add("user", "maria");
            cookies["email"] = "maria@gmail.com";
            cookies.Add("phone", "88888-8888");
            cookies["phone"] = "99999-9999";   // Aqui o valor da chave "phone" foi substituido

            Console.WriteLine(cookies["phone"]);

            Console.WriteLine("--------------------");

            foreach (string x in cookies.Values)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("--------------------");

            foreach (KeyValuePair<string, string> item in cookies)  // Poderia usar tb: foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine("--------------------");

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }


        }
    }
}

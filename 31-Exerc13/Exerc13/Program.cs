using System;
using System.Globalization;
using Exerc13.Entities;
using Exerc13.Entities.Enums;

namespace Exerc13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int quantityItems = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Order order = new Order(DateTime.Now, orderStatus, client);

            for (int i = 1; i <= quantityItems; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");

                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(nameProduct, priceProduct);

                Console.Write("Quantity: ");
                int quantityProduct = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantityProduct, priceProduct, product);

                order.AddItem(orderItem);
                Console.WriteLine();
            }

            Console.WriteLine(order);


        }
    }
}

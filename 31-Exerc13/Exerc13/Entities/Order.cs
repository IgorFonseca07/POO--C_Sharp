using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Exerc13.Entities.Enums;

namespace Exerc13.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.00;
            foreach (OrderItem orderItem in OrderItems)
            {
                sum += orderItem.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + OrderStatus);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToShortDateString() + ") - " + Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem orderItem in OrderItems)
            {
                sb.Append(orderItem.Product.Name + ", $" + orderItem.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.AppendLine(", Quantity: " + orderItem.Quantity + ", Subtotal: $" + orderItem.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}

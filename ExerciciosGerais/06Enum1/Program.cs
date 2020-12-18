using System;
using _06Enum1.Entities;
using _06Enum1.Entities.Enums;

namespace _06Enum1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
        }
    }
}

using System;
using System.Collections.Generic;
using PredicateDelegate.Entities;

namespace PredicateDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 90.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.50));

            list.RemoveAll(ProductTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100;
        }
    }
}

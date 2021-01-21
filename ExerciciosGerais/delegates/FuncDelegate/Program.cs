using System.Linq;
using System.Collections.Generic;
using FuncDelegate.Entities;
using System;

namespace FuncDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.00));

            Func<Product, string> func = p => p.Name.ToUpper();
            //Func<Product, string> func = NameUpper;
            List<string> result = list.Select(func).ToList();
            
            //List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            //List<string> result = list.Select(NameUpper).ToList();

            foreach (string p in result)
            {
                Console.WriteLine(p);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}

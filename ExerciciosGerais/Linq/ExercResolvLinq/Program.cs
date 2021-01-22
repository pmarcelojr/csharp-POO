using System;
using System.Linq;
using System.Globalization;
using ExercResolvLinq.Entities;
using System.IO;
using System.Collections.Generic;

namespace ExercResolvLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> listProduct = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(",");
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    listProduct.Add(new Product(name, price));
                }
            }

            var avg = listProduct.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Average price = {avg.ToString("f2", CultureInfo.InvariantCulture)}");

            var names = listProduct.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

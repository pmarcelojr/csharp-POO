using System;
using System.Globalization;
using System.Collections.Generic;
using TaxaImpostos.Entities;

namespace TaxaImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax Payer #{i + 1} data:");
                Console.Write("Individual or Company (i/c): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(type == 'i' || type == 'I')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, rendaAnual, healthExpenditure));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberEmployee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, rendaAnual, numberEmployee));
                }
            }

            Console.Clear();

            double sum = 0.0;
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer taxPayer in list)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("f2", CultureInfo.InvariantCulture)}");
                sum += tax;
            }

            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}

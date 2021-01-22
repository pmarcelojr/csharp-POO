using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using ExercFixacao.Entities;

namespace ExercFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(",");
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }
                Console.WriteLine();
                Console.Write("Enter salary: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"Email of people whose salary is more than {value.ToString("f2", CultureInfo.InvariantCulture)}");

                var emails = list.Where(p => p.Salary > value).OrderBy(p => p.Name).Select(p => p.Email);
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.WriteLine();
                var sumSalary = list.Where(p => p.Name[0].Equals('M')).Sum(p => p.Salary);
                Console.Write($"Sum of salary of people whose name starts with 'M': {sumSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

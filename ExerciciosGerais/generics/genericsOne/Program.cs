using System;
using genericsOne.Services;

namespace genericsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            Console.Write("Print all: ");
            printService.Print();
            Console.WriteLine($"\nFirst: {printService.First()}");
        }
    }
}

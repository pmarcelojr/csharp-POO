using System;
using System.Globalization;

namespace _016VetorExercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write("Entre com o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Entre com o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0 ; i < vect.Length; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }   
    }
}

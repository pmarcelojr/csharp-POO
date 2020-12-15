using System;
using System.Globalization;

namespace _015VetorExercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade do vetor: ");
            int N = int.Parse(Console.ReadLine());
            // Instanciando vetor
            double[] vect = new double[N];

            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine("Entre com a altura: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < vect.Length; i++)
            {
                sum += vect[i];
            }

            double avg = sum / N;
            Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

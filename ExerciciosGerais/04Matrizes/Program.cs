using System;

namespace _04Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n , n];

            for(int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.Write("Entre com os numeros escolhidos na mesma linha: ");
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
        }
    }
}

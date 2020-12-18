using System;

namespace _04Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Entre com um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n , n];

            // Preenchendo a matriz
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
            Console.Clear();
            Console.Write("Diagonal principal: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{mat[i,i]} ");
            }
            // Contando valores negativos na matriz
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        count++;
                }
            }
            Console.Write($"A quantidade de numeros negativos é {count}");
        }
    }
}

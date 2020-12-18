using System;

namespace _05Matrizes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Entre com o numero de linhas da matriz: ");
            int L = int.Parse(Console.ReadLine());
            Console.Write("Entre com o numero de colunas da matriz: ");
            int C = int.Parse(Console.ReadLine());
            Console.Clear();

            int[,] mat = new int[L,C];
            // Preenchendo a matriz
            for(int i = 0; i < L; i++)
            {
                Console.Write($"Entre com os numeros da linha {i}: ");
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < C; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

        }
    }
}

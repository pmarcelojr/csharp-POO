using System;

/*
    Fazer um programa para ler dois números inteiros L e C, e depois ler uma matriz de L linhas por C colunas contendo números inteiros, podendo haver repetições.
    Em seguida, ler um número inteiro X que pertence á matriz.
    Para cada ocorrência de X, mostrar os valores á esquerda, acima, á direita e abaixo de X, quando houver.
*/

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
            Console.Clear();
            Console.Write("Escolha um numero pertencente a matriz: ");
            int X = int.Parse(Console.ReadLine());

            string[] localizacao = new string[C];
            for(int i = 0; i < L; i++)
            {
                for(int j = 0; j < C; j++)
                {
                    if(mat[i, j] == X)
                    {
                        Console.WriteLine($"Posição {i},{j}:");
                        localizacao[0] = j == 0 ? "" : mat[i, j - 1].ToString();
                        Console.WriteLine($"Esqueda: {localizacao[0]}");
                        localizacao[1] = j == mat.GetUpperBound(1) ? "" : mat[i, j + 1].ToString();
                        Console.WriteLine($"Direita: {localizacao[1]}");
                        localizacao[2] = i == 0 ? "" : mat[i - 1, j].ToString();
                        Console.WriteLine($"Acima: {localizacao[2]}");
                        localizacao[3] = i == mat.GetUpperBound(0) ? "" : mat[i + 1, j].ToString();
                        Console.WriteLine($"Abaixo: {localizacao[3]}");
                        Console.WriteLine("-----------------");
                    }
                }
            }
        }
    }
}

using System;

/*
    Ler uma sequência de TAM números inteiros positivos e escrevê-la pela ordem inversa da sua leitura
    O TAM deve poder ser alterado sem afetar o resto do programa
    ** Com Constante
*/

namespace ComConstante
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 5;
            int[] lista = new int[TAM];
            int conta = 0;
            int num = 0;
            while (conta < TAM)
            {
                Console.Write("Entre com um Numero: ");
                num = int.Parse(Console.ReadLine());
                if(num >= 0)
                {
                    conta += 1;
                    lista[conta - 1] = num;
                }
            }
            for(int i = TAM-1; i >= 0; i--)
            {
                Console.WriteLine($"f> Posicao {i} valor {lista[i]}");
            }
            // Soma todas
            int soma = 0;
            for(int i = 0; i < TAM; i++)
            {
                soma += lista[i];
            }
            Console.WriteLine($"a> Soma {soma}");
        }
    }
}

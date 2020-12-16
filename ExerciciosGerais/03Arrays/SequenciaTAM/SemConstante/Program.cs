using System;

/*
    Ler uma sequência de TAM números inteiros positivos e escrevê-la pela ordem inversa da sua leitura
    O TAM deve poder ser alterado sem afetar o resto do programa
    ** Sem Constante
*/

namespace SemConstante
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[20];
            int conta = 0;
            int num = 0;

            while(conta < 20)
            {
                Console.Write("Numero: ");
                num = int.Parse(Console.ReadLine());
                if(num >= 0)
                {
                    conta += 1;
                    lista[conta - 1] = num;
                }
            }
            conta = 20;
            while (conta > 0)
            {
                conta -= 1;
                Console.WriteLine($"Posicao {conta} valor {lista[conta]}");
            }
        }
    }
}

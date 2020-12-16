using System;

/*
Ler uma sequência de números inteiros positivos de comprimento desconhecido (terminada por 0) e escrevê-la pela ordem inversa da sua leitura
*/

namespace TamDesconhecido
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[10];
            int conta = 0;
            int num = 0;
            bool continua = true;
            while(continua)
            {
                Console.Write("Entre com o numero: ");
                num = int.Parse(Console.ReadLine());
                if(num > 0)
                {
                    list[conta] = num;
                    conta += 1;
                }
                else
                {
                    if(num == 0)
                    {
                        continua = false;
                        conta -= 1; // Posicao do ultimo numero valido
                    }
                    else
                    {
                        Console.WriteLine("Numero introduzido tem de ser positivo");
                    }
                }
            }
            for(int i = conta; i >= 0; i--)
            {
                Console.WriteLine($"Posição {i} valor {list[conta]}");
            }
        }
    }
}

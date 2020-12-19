using System;

namespace _02NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random r = new Random();
            Console.WriteLine("--- Seja Bem Vindo ao Jogo da Adivinhação ---");
            Console.Write("Entre com um número inicial: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Entre com um número final: ");
            int y = int.Parse(Console.ReadLine());
            
            int winNum = r.Next(x, y);
            bool win = false;

            do
            {
                Console.WriteLine($"Entre com um numero entre {x} e {y}: ");
                int n = int.Parse(Console.ReadLine());

                if(n > winNum)
                    Console.WriteLine("Numero Acima, um pouco mais para baixo...");
                else if (n < winNum)
                    Console.WriteLine("Numero Abaixo, um pouco mais para cima...");
                else if (n == winNum)
                {
                    Console.Clear();
                    Console.WriteLine("***** Você é o Vencedor!!! *****");
                    win = true;
                }
            } while (win == false);

            Console.WriteLine("\nObrigado por jogar!");
            Console.Write("Press any key to finish...");
            Console.ReadKey(true);
            
        }
    }
}

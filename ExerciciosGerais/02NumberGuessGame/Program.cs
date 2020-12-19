using System;

namespace _02NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random r = new Random();
            int winNum = r.Next(0, 100);
            bool win = false;

            do
            {
                Console.WriteLine("Entre com um numero entre 0 e 100: ");
                string i = Console.ReadLine();
                int n = int.Parse(i);

                if(n > winNum)
                    Console.WriteLine("Numero acima!");
                else if (n < winNum)
                    Console.WriteLine("Numero abaixo!");
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

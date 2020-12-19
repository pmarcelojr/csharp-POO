﻿using System;

namespace _02NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random r = new Random();
            int winNum = r.Next(0, 10);
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
                    Console.WriteLine("Você é o Vencedor!!!");
                    win = true;
                }
            } while (win == false);
            
        }
    }
}
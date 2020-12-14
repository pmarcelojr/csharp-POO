using System;

namespace _014Interface
{
    class Calculo : IPadrao
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine($"A soma é {n1 + n2}");
        }
        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine($"A subtração é {n1 - n2}");
        }
    }
}
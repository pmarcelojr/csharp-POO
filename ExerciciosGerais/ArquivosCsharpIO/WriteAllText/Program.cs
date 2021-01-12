using System;
using System.IO;

namespace WriteAllText
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Isto é uma string";
            File.WriteAllText("arquivo1.txt", texto);

            Console.ReadKey();
        }
    }
}

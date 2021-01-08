using System;
using System.IO;

namespace _15a_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // // 1: Escreve uma linha para novo arquivo
            // using (StreamWriter sw = new StreamWriter(@"C:\temp\macoratti.txt", true))
            // {
            //     sw.WriteLine("Macorrati .net");
            // }
            // // 2: Anexa uma linha ao arquivo
            // using (StreamWriter sw = new StreamWriter(@"C:\temp\macoratti.txt", true))
            // {
            //     sw.WriteLine("Quase tudo para .net");
            // }
            /////////////////////////////////////////////////////////////////////////////
            using(var sw = new StreamWriter(@"C:\temp\macoratti.txt"))
            {
                // Percorre o laço
                for (int i = 0; i < 10; i++)
                {
                    // Escreve uma string formatada
                    sw.WriteLine("{0:0.0} ", i);
                }
            }
        }
    }
}

using System;
using System.IO;

namespace WriteAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = {"Primeira sentença", "Segunda sentença", "Terceira sentença" };

            File.WriteAllLines("arquivo1.txt", lines);
        }
    }
}

using System;
using System.Collections.Generic;

namespace HashSetExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("geladeira"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}

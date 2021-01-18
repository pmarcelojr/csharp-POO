using System;
using System.Collections.Generic;
using System.IO;
using exercicioSet.Entities;

namespace exercicioSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(' ');
                        string name = vect[0];
                        DateTime instant = DateTime.Parse(vect[1]); 
                        set.Add(new LogRecord { UserName = name, Instant = instant } );
                    }
                    Console.WriteLine($"Total users: {set.Count}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

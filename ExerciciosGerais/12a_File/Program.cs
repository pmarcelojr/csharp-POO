using System;
using System.IO;

namespace _12a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sourcePath = @"C:\temp\MyTest.txt";
                
                if(!File.Exists(sourcePath))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(sourcePath))
                    {
                        sw.WriteLine("Hello");
                        sw.WriteLine("And");
                        sw.WriteLine("Welcome");
                    }
                }

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    string s;
                    while((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}

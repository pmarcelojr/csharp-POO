using System;
using System.IO;
using System.Collections.Generic;

namespace _16DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\myfolder";

            try
            {
                // Lista as pastas a partir de uma pasta informada
                IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
                
                Console.WriteLine("---------------------------------------");
                // Lista os arquivos a partir de uma pasta informada
                IEnumerable<string> files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach(string s in files)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("---------------------------------------");
                // Criar uma pasta
                Directory.CreateDirectory($@"{sourcePath}\newFolder");
                Console.WriteLine("Nova pasta criada!");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);                
            }
        }
    }
}

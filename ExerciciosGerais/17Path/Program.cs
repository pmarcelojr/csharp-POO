using System;
using System.IO;

namespace _17Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\temp\myfolder\file1.txt";

            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
            Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
            Console.WriteLine($"GetFileName: {Path.GetFileName(sourcePath)}");
            Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(sourcePath)}");
            Console.WriteLine($"GetExtension: {Path.GetExtension(sourcePath)}");
            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(sourcePath)}");
            Console.WriteLine($"GetFullPath: {Path.GetFullPath(sourcePath)}");
            Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");
        }
    }
}

using System;
using exercMethodElapsedTime.Extensions;

namespace exercMethodElapsedTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 1, 18, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}

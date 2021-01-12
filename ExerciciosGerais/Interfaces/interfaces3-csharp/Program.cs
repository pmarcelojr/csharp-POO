using System;
using interfaces3_csharp.Device;

namespace interfaces3_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());
        }
    }
}

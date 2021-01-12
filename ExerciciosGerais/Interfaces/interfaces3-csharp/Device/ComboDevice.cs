using System;

namespace interfaces3_csharp.Device
{
    class ComboDevice : Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine($"Combo Device Print: {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Combo Device Processing: {document}");
        }

        public string Scan()
        {
            return "Combo Device Scan result";
        }
    }
}
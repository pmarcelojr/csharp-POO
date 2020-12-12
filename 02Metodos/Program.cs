using System;

namespace _02Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Apresentar();
            p1.Apresentar("Marcelo");
            p1.Apresentar("David", 30);
        }
    }
}

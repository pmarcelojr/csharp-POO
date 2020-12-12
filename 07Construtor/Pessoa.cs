using System;

namespace _07Construtor
{
    class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Construtor Executado");
        }
        public Pessoa(string nome)
        {
            Console.WriteLine($"Ola {nome}");
        }
    }
}
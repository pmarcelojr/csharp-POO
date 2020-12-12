using System;

namespace _02Metodos
{
    class Pessoa
    {
        // Metodo 01
        public void Apresentar()
        {
            Console.WriteLine("Olá");
        }
        // Metodo 02
        public void Apresentar(string nome)
        {
            Console.WriteLine($"Olá {nome}");
        }
        // Metodo 03
        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine($"Olá {nome} você tem {idade} anos");
        }
    }
}
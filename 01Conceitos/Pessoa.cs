using System;

namespace _01Conceitos
{
    class Pessoa
    {
        // Atributos
        public string nome;
        public int idade;

        // Metodos
        public void Mensagem()
        {
            Console.WriteLine($"Olá {nome} você tem {idade} anos");
        }
    }
} 
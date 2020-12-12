using System;

namespace _010Heranca
{
    class Pessoa
    {
        protected string nome;
        protected int idade;

        protected void MensagemPessoa()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}
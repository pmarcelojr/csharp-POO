using System;

namespace _09This
{
    class Pessoa
    {
        private string _nome;

        public Pessoa(string nome)
        {
            // o this sempre liga o atributo da classe com o metodo.
            this._nome = nome;
            Console.WriteLine(_nome);
        }
    }
}
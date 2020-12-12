using System;

namespace _08GetSet
{
    class Pessoa
    {
        private string nome;

        // Get e Set
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
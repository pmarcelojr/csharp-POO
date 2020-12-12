using System;

namespace _010Heranca
{
    class Colaborador : Pessoa
    {
        private double salario;

        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;

            MensagemPessoa();
            MensagemColaborador();
        }
        private void MensagemColaborador()
        {
            Console.WriteLine($"Salario: {salario}");
        }
    }
}
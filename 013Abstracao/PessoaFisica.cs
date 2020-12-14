using System;

namespace _013Abstracao
{
    class PessoaFisica : Padrao
    {
        // metodo obrigatorio
        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de emprestimo para pessoa fisica R$ {valor * 0.1}");
        }
    }
}
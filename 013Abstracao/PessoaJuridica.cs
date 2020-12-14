using System;

namespace _013Abstracao
{
    class Pessoajuridica : Padrao
    {
        // metodos obrigatorios
        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de emprestimo para pessoa juridica R$ {valor * 0.2}");
        }
    }
}
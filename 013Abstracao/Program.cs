using System;

namespace _013Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.TaxaEmprestimo(1000);
            Pessoajuridica pj = new Pessoajuridica();
            pj.TaxaEmprestimo(1000);
        }
    }
}

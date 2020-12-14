using System;

namespace _013Abstracao
{
    abstract class Padrao
    {
        // obrigatorio
        public abstract void TaxaEmprestimo(double valor);

        // opcional
        public void CalculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine($"Ganhos obtidos pela poupança R$ {valor * taxa}");
        }
    }
}
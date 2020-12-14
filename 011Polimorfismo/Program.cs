using System;

namespace _011Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar estagiario
            Imposto objE = new Estagiario();
            objE.ValeAlimentacao(1000);
            objE.ValeTransporte(1000);
            Console.WriteLine("----------------------------");
            // Instanciar Gerente
            Imposto objG = new Gerente();
            objG.ValeAlimentacao(5000);
            objG.ValeTransporte(5000);
            Console.WriteLine("----------------------------");
            // Instanciar Atendente
            Imposto objA = new Atendente();
            objA.ValeAlimentacao(2000);
            objA.ValeTransporte(2000);
            
        }
    }
}

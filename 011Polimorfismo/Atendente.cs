using System;

namespace _011Polimorfismo
{
    class Atendente : Imposto
    {
        public override void ValeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto atendende do vale transporte R$ {salario * 0.12}");
        }
    }
}
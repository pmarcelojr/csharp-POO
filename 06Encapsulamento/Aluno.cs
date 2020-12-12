using System;

namespace _06Encapsulamento
{
    class Aluno
    {
        // Atributos
        private double nota1, nota2;
        // media
        private double Media()
        {
            return (nota1 + nota2) / 2;
        }
        // Mensagem
        public void Mensagem()
        {
            Console.WriteLine("Entre com a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A media é " + Media());
        }
    }
}
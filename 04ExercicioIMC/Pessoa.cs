using System;

namespace _04ExercicioIMC
{
    class Pessoa
    {
        // Atributos
        public double peso;
        public double altura;

        // metodos
        public double CalcularIMC()
        {
            return peso / (altura * altura);
        }
        public string ResultadoIMC(double CalcularIMC)
        {
            if (CalcularIMC < 18.5)
                return "Abaixo do peso";
            else if (CalcularIMC < 25)
                return "Peso normal";
            else if (CalcularIMC < 30)
                return "Acima do peso";
            else if (CalcularIMC < 35)
                return "Obesidade 1";
            else if (CalcularIMC < 40)
                return "Obesidade 2";
            else
                return "Obesidade 3";
        }
        public void Mensagem()
        {
            double Calculo = CalcularIMC();
            string Resultado = ResultadoIMC(Calculo);
            Console.WriteLine($"O resultado do seu IMC é {Resultado}");
        }
    }
}
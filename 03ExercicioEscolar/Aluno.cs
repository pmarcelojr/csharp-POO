using System;

namespace _03ExercicioEscolar
{
    class Aluno
    {
        // Atributos
        public string nome;
        public double nota1, nota2;

        // Média
        public double Media()
        {
            return (nota1 + nota2) / 2;
        }
        // Situação
        public string Situacao(double Media)
        {
            if(Media >= 7)
                return "APROVADO";
            else
                return "REPROVADO";
        }
        // Mensagem
        public void Mensagem()
        {
            // obter media
            double obterMedia = Media();
            // obter situacao
            string obterSituacao = Situacao(obterMedia);
            // mensagem
            Console.WriteLine($"{nome} está {obterSituacao} com média {obterMedia}");
        }
    }
}
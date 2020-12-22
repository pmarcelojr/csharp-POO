﻿using System;
using System.Collections.Generic;

namespace SorteioSemRepetir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sorteando dez números que estejam entre o intervalo de 1 a 10.
            Console.WriteLine(string.Join(", ", SorteiaNumerosSemRepetir(10, 1, 10)));
        }

        private static int[] SorteiaNumerosSemRepetir(int qtd, int min, int max)
        {
            // Validações dos argumentos
            if (qtd < 0)
                throw new ArgumentException("Quantidade deve ser maior que zero");
            else if (qtd > max + 1 - min)
                throw new ArgumentException("Quantidade deve ser maior do que a diferença entre máximo e mínimo");
            else if (max <= min)
                throw new ArgumentException("Máximo deve ser maior do que o mínimo");

            List<int> numerosSorteados = new List<int>();
            Random rnd = new Random();

            while (numerosSorteados.Count < qtd)
            {
                int numerosSorteado = rnd.Next(min, max + 1);

                // Numero já foi sorteado? Entao sorteamos novamente ate o numero não ter sido sorteado ainda.
                while (numerosSorteados.Contains(numerosSorteado))
                    numerosSorteado = rnd.Next(min, max + 1);
                
                numerosSorteados.Add(numerosSorteado);
            }

            return numerosSorteados.ToArray();
        }
    }
}

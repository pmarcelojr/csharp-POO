﻿using System;

namespace _05Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.nome = "jeferson"; // ok
            // p.valor ??? nao é visivel
        }
    }
}
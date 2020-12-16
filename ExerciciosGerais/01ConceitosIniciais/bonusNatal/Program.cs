using System;

/*
    Uma empresa atribui aos seus colaboradores um bónus de Natal que é função do número de filhos e do número de anos de serviço, calculado da seguinte forma:
- 20 $ por filho
- 10 $ por ano de serviço
O programa lê o nº de filhos e o nº de anos de serviço do colaborador e calcula o valor do bónus que lhe deve ser atribuído
*/

namespace bonusNatal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de filhos");
            int filhos = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de anos de serviço: ");
            int anos = int.Parse(Console.ReadLine());

            int bonus = 20 * filhos;
            bonus = bonus + (anos * 10);
            Console.WriteLine($"O valor do bonus é {bonus}");
        }
    }
}

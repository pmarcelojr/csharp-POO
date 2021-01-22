using System;
using System.Linq;
using System.Collections.Generic;
using LinqPerson.Entities;

namespace LinqPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("João", 15),
                new Person("Leandro", 21),
                new Person("Paulo", 17),
                new Person("jessica", 18)
            };

            Console.WriteLine("Lista de pessoas: ");
            people.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();

            Person mostOlder = MostOlderPerson(people);
            Console.WriteLine($"Pessoa mais velha: {mostOlder}");

            Console.WriteLine();
            Console.Write("Digite o nome de quem gostaria de procurar? ");
            string findName = Console.ReadLine();

            Person findPerson = FindPerson(findName, people);
            if (findPerson != null)
            {
                Console.WriteLine($"{findName} existe e sua idade é: {findPerson.Age}");
            }
            else
            {
                Console.WriteLine($"Não foi encontrado nenhum nome {findName}");
            }

            RemoverUnder18(people);
            Console.WriteLine();

            Console.WriteLine("Lista de pessoas atualizada: ");
            people.ForEach(p => Console.WriteLine(p));
        }

        static Person MostOlderPerson(List<Person> people)
        {
            // Compara duas idades e retorna qual idade é maior
            return people.Aggregate((x, y) => x.Age > y.Age ? x : y);
        }

        static Person FindPerson(string name, List<Person> people)
        {
            // Procura pessoa
            return people.Where(p => p.Name.Equals(name)).SingleOrDefault();
        }

        static void RemoverUnder18(List<Person> people)
        {
            people.RemoveAll(p => p.Age < 18);
        }
    }
}

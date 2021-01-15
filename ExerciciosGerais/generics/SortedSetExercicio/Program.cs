using System;
using System.Collections.Generic;

namespace SortedSetExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 10, 2, 4, 5, 6, 8, 15 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 20, 9, 10 };

            // Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.Write("Union: ");
            PrintCollection(c);

            // Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.Write("Intersection: ");
            PrintCollection(d);

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("Difference: ");
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();
        }
    }
}

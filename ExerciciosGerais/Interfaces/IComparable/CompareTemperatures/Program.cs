using System;
using System.Collections;
using System.Collections.Generic;
using CompareTemperatures.Entities;

namespace CompareTemperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList temperatures = new ArrayList();
            // Initialize random number generator
            Random rnd = new Random();

            // Generate 10 temperatures betweem 0 and 100 randonly
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int degrees = rnd.Next(0, 100);
                Temperature temp = new Temperature();
                temp.Fahrenheit = degrees;
                temperatures.Add(temp);
            }

            // Sort ArrayList
            temperatures.Sort();

            foreach (Temperature temp in temperatures)
            {
                Console.WriteLine(temp.Fahrenheit);
            }
        }
    }
}

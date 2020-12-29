using System;
using System.Globalization;
using System.Collections.Generic;
using _09ClassMethodsAbstract.Entities;
using _09ClassMethodsAbstract.Entities.Enums;

namespace _09ClassMethodsAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape ${i + 1} data:");
                Console.Write("Rectangle or Circle (r/c): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Color: (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(type == 'r' || type == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(color, radius));
                }
            }

            Console.Clear();
            Console.WriteLine("SHAPE AREAS:");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}

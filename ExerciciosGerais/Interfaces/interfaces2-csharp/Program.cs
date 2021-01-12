using System;
using interfaces2_csharp.Model.Entities;
using interfaces2_csharp.Model.Enums;

namespace interfaces2_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle() { Radius = 2.0, Color = Color.Black };
            Shape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black }; 

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}

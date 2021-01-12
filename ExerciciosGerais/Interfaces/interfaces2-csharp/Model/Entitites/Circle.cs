using System;
using System.Globalization;

namespace interfaces2_csharp.Model.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = " + Color
                    + ", Radius = " + Radius.ToString("f2", CultureInfo.InvariantCulture)
                    + ", Area = " + Area().ToString("f2", CultureInfo.InvariantCulture); 
        }
    }
}
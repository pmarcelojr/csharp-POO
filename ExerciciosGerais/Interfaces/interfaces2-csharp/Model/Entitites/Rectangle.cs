using System.Globalization;

namespace interfaces2_csharp.Model.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return "Rectangle color = " + Color
                    + ", Width = " + Width.ToString("f2", CultureInfo.InvariantCulture)
                    + ", Height = " + Height.ToString("f2", CultureInfo.InvariantCulture)
                    + ", Area = " + Area().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
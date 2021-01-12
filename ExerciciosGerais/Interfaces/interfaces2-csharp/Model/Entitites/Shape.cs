using interfaces2_csharp.Model.Enums;

namespace interfaces2_csharp.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
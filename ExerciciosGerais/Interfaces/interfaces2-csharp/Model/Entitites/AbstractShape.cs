using interfaces2_csharp.Model.Enums;

namespace interfaces2_csharp.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
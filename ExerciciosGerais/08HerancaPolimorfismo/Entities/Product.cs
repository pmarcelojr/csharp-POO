using System.Globalization;

namespace _08HerancaPolimorfismo.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }

        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
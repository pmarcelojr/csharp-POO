using System.Globalization;

namespace SQLLinq.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Price.ToString("f2", CultureInfo.InvariantCulture)}, {Category.Name}, {Category.Tier}";
        }
    }
}
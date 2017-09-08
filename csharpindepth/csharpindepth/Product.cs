using System.Collections.Generic;

namespace csharpindepth
{
    public class Product
    {
        readonly string name;
        public string Name { get { return name; } }

        readonly decimal price;
        public decimal Price { get { return price; } }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product> SampleProducts => new List<Product>
        {
            new Product(name : "West Side Story", price : 9.99m),
            new Product(name : "Assassins", price : 14.99m),
            new Product(name : "Forgs", price : 13.99m),
            new Product(name : "Sweeney Todd", price : 10.99m)
        };

        public override string ToString() => string.Format("{0}: {1}", Name, Price);
    }
}

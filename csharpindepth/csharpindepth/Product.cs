using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpindepth
{
    public class Product
    {
        // !!! You've provided public getter properties, which means that if you wanted matching setters, they'd have to be public, too.

        string name;
        public string Name { get { return name; } }

        decimal price;
        public decimal Price { get { return price; } }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new Product("West Side Story", 9.99m));
            list.Add(new Product("Assassins", 14.99m));
            list.Add(new Product("Forgs", 13.99m));
            list.Add(new Product("Sweeney Todd", 10.99m));
            list.Add("error things!"); // !!! An ArrayList has no comile-time information about what's in it.
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }

        // !!! There's a lot of fluff involved in encapsulating a string and a decimal.
    }
}

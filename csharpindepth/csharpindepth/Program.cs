using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace csharpindepth
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var p in Product.SampleProducts.Where(p => p.Price > 10).OrderBy(p => p.Name)) // extension method.
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpindepth
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var p in Product.GetSampleProducts())
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Lambida4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product(" TV", 900.00));
            list.Add(new Product(" Monitor", 500.00));
            list.Add(new Product(" Mouse", 50.00));
            list.Add(new Product(" Teclado", 100.00));

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using Entities;
using Services;
using System.Globalization;

namespace Lambida5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            {
                list.Add(new Product("TV", 900.00));
                list.Add(new Product("Monitor", 80.00));
                list.Add(new Product("Mouse", 50.00));
                list.Add(new Product("Tablet", 350.00));

                ProductService ps = new ProductService();

                double sum = ps.FilteredSum(list, p => p.Name[0] == 'T');

                Console.WriteLine(" sum = " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

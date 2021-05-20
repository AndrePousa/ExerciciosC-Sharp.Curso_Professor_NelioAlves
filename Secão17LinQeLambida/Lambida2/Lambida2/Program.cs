using System;
using System.Collections.Generic;

namespace Lambida2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));
            list.Add(new Product("Monitor", 500.00));
            //Remova todos os elementos da lista que sejam maior e igual a 100.00
            list.RemoveAll(p => p.Price >= 100.0);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Lambida1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            //Adicionando itens a lista
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notbook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            //Product p in list
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}

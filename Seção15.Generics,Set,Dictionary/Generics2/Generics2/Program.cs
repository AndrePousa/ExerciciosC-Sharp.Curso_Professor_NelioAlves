using System;
using System.Collections.Generic;
using Generics2.Entities;
using Generics2.Services;
using System.Globalization;

namespace Generics2
{
    class Program
    {    //Ler nome e preço separados por ,
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i< n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }
            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list); //Produto é opicional

            Console.WriteLine("O maior valor é: ");
            Console.Write(p);
        }
    }
}

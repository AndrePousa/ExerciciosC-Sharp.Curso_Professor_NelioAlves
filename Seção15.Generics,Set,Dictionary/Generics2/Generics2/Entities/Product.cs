using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Generics2.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        //Testar se obj é do tipo product
        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not an Product");

            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

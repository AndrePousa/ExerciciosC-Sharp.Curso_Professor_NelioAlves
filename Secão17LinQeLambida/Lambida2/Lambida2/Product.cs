using System.Collections.Generic;
using System.Globalization;

namespace Lambida2
{
    class Product
    {
        public double Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }   
        
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }              
    }
}

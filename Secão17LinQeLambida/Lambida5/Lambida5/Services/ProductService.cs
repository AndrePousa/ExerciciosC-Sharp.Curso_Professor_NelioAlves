using System;
using System.Collections.Generic;
using Entities;

namespace Services
{
    class ProductService
    {
        public double FilteredSum(List<Product> list, Func<Product, bool> Criteria)
        {
            double sum = 0.0;
            foreach (Product p in list)
            {
                if (Criteria.Invoke(p))
                {
                    sum += p.Price;
                }
            }
            return sum;
        }
    }
}

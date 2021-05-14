using System;
using GeteHasCodeEqualsPersonalizado.Entities;

namespace GeteHasCodeEqualsPersonalizado
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "André", Email = "andre@gmail" };
            Client b = new Client { Name = "Lilian", Email = "lilian@gmail" };

            Console.WriteLine(a.Equals(b));

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}

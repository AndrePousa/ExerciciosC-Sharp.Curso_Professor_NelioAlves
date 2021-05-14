using System;

namespace GetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "José";
            //mais rapido 
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}

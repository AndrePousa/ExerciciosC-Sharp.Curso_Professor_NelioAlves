using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R;
            R = new Retangulo(); 

            Console.Write("Entre com a largura do retangulo: ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com a Altura do retangulo: ");          
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + R.Perimetro().ToString ("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}

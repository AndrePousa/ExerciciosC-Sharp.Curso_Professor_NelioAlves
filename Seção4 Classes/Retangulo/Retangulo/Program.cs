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


            Console.WriteLine("Entre com a largura e altura do retangulo");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area = " + R.Perimetro().ToString ("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area = " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture)); 
           
           
                

            

            
           


        }
    }
}

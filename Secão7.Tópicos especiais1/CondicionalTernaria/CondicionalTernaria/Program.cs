using System;
using System.Globalization;

namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opcional ao if-else quando se deseja decidir um valor com base em uma condição

            /* Sintaxe:
               (condição) ? valor_se_verdadeiro : valor_se_falso

            Exemplos:
               (2 > 4) ? 50 : 80 ---------> 80

               (10 != 3) ? "Maria" : "Alex" ----------->  "Maria" */

            Console.WriteLine("Digite o preço");

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            /* if( preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            } */

            Console.WriteLine(desconto);
        }
    }
}

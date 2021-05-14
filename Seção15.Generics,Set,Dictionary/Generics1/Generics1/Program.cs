using System;

namespace Generics1
{
    class Program
    {   // o programa principal deve ser alterado para string se quiser rodar string
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.WriteLine("Quantos valores você irá digitar ? ");
            int n = int.Parse(Console.ReadLine());

            for( int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
                    
            }

            printService.Print();
            Console.WriteLine("Primeiro: " + printService.First());
        }
    }
}

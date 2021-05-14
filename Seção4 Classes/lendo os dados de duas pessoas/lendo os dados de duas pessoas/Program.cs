using System;

namespace lendo_os_dados_de_duas_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoas p1;
            Pessoas p2;

            p1 = new Pessoas();
            p2 = new Pessoas();
            
            Console.WriteLine("Digite o nome da primeira pessoa");
            p1.Nome = Console.ReadLine();
            Console.WriteLine(" digite a idade");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da  Segunda pessoa");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade");
            p2.Idade = int.Parse(Console.ReadLine());

            if( p1.Idade > p2.Idade)
            {
                Console.WriteLine(" A pessoa mais velha é " + p1.Nome);
            }

            else
            {
                Console.WriteLine(" A pessoa mais velha é " + p2.Nome);
            }

            

           
            

            
            


           


             
        }
    }
}

using System;
using System.Linq;

namespace IntroducaoaoLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Definine the query expression
            //definição de consulta
            //Pegar todo numero que for par e multiplica -lo por 10

            //variavel resultado será a fonte de dados. 
            //extension metodos

            //where filtra a fonte de dados
            //gerar uma coleção que atender os predicados que eu informar como argumento da operação
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}

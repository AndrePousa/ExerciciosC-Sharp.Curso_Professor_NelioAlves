using System;
using System.Linq; //importando o namespace do linq
using System.Collections.Generic;

namespace IntroducaoaoLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especificar a fonte de dados
            // Specify the data source.
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Define the query expression.
            //Definição de consulta
            //Pegar todo numero que for par e multiplica-lo por 10

            //variavel resultado será a fonte de dados. 
            //Extension metodos

            //Where filtra a fonte de dados
            //Gerar uma coleção que atender os predicados que eu informar como argumento da operação
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}

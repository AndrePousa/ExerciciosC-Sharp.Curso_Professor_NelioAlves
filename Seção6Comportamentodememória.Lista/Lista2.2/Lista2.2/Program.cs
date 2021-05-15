using System;
using System.Collections.Generic;

namespace Lista2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();

            list.Add("André");
            list.Add("Andrei");
            list.Add("Lilian");
            list.Add("Carlos");
            list.Add("Cleusa");
            list.Add("Luzia");
            list.Add("André");
            list.Add("André");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //função .Find recebe como algumento uma função que faz um teste
            // string s1 = list.Find(Test);
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Firs 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A':" + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("A posição do primeiro elemento que começa com A é :" + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("A ultima posição do ultimo elemento que começa com A é :" + pos2);

            //Filtrar a lista = criar uma nova lista contendo apenas o elemento que satisfaçam o predicado.

            List<string> list2 = list.FindAll(x => x.Length == 5);

            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine("Os nomes são: " + obj);
            }
        }

        /* static bool Test(string s)
         {
             return s[0] == 'A';
         }*/
    }
}

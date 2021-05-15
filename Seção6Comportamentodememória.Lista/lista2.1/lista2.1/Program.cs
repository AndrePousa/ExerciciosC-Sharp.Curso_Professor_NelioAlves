using System;
using System.Collections.Generic;

namespace lista2._1
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

            foreach(String obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            Console.ReadLine();         
        }
    }
}

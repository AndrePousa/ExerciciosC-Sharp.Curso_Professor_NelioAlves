using System;
using System.Collections.Generic;

namespace ExLista2._3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("André");
            list.Add("Paoulo");
            list.Add("João");
            list.Add("Jean");

            list.Remove("Paulo");
            list.RemoveAll(x => x[0] == 'j');
        }
    }
}

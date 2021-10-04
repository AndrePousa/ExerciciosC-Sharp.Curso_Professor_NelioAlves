using System;
using System.IO;
using System.Collections.Generic;


namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {    //informando o caminho do arquivo
            string path = @"c:\temp\in.txt";
            try
            {    //abrindo o arquivo 
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    //metodo que ordena a lista
                    //o objeto da lista tem que 
                    //.Sort ordena a lista
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

    }
}

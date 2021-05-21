using System;
using System.Globalization;
using System.Collections.Generic;
using Lambida7LerArquivo.Entities;
using System.IO;
using System.Linq;

namespace Lambida7LerArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Entre com o caminho completo do arquivo ");
            string path = Console.ReadLine();
            Console.Write(" Entre com o salário: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                    var emails = list.Where(obj => obj.Salary > limit)
                        .OrderBy(obj => obj.Email)
                        .Select(obj => obj.Email);

                    var sum = list.Where(obj => obj.Name[0] == 'M')
                        .Sum(obj => obj.Salary);

                    Console.WriteLine(" Email das pessoas cujo salário é maior que " + limit.ToString("F2", CultureInfo.InvariantCulture));
                    foreach (string email in emails)
                    {
                        Console.WriteLine(email);
                    }
                    Console.WriteLine("Soma do salário das pessoas que começam com a letra 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
             catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            Console.WriteLine("Precione Enter para sair");
            Console.ReadLine();
        }
    }
}




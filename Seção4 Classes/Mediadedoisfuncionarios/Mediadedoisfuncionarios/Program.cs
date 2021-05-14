using System;
using System.Globalization;
namespace Mediadedoisfuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1;
            Funcionarios f2;

            f1 = new Funcionarios();
            f2 = new Funcionarios();

            Console.WriteLine("Digite o nome do primeiro funcionario");
            f1.Nome = (Console.ReadLine());
            Console.WriteLine("Digite o salário");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do segundo funcionario");
            f2.Nome = (Console.ReadLine());
            Console.WriteLine("Digite o Salario");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           
            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine(" O salario médio é = " + media.ToString("F2", CultureInfo.InvariantCulture)); 



            
        }
    }
}

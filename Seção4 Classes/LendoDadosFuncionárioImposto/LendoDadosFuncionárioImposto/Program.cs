using System;
using System.Globalization;

namespace LendoDadosFuncionárioImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Digite o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.Write("Digite o Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(f);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário para qual % ?: ");
            double Porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + f);         
        }
    }
}

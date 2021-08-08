using System;
using System.Globalization;
using Interfaces1.Csharp.Entidades;
using Interfaces1.Csharp.Serviços;

namespace Interfaces1.Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a  Data do Aluguel");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("Pickup(dd/MM/yyyy HH:MM): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MMyyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o valor por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor por dia; ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarroAluguel carroAluguel = new CarroAluguel(start, finish, new Veiculo(model));

            ServiçodeAluguel serviçodealuguel = new ServiçodeAluguel(hora, dia, new BrasilTaxaServiço());

            serviçodealuguel.ProcessoFatura(carroAluguel);

            Console.WriteLine("Fatura: ");
            Console.WriteLine(carroAluguel.Fatura);
        }      
    }
}

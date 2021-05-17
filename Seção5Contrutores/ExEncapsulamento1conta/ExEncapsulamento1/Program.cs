using System;
using System.Globalization;

namespace ExEncapsulamento1
{
    class Program
    {
        static void Main(string[] args)
        {   //declaração da classe conta. 
            ContaBancaria conta;

            Console.WriteLine("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Titular da conta: ");
            string titular = (Console.ReadLine());
            Console.Write("Haverá deposito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());

            if( resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor do depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoinicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta :");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.ReadLine();
        }
    }
}

using System;
using System.Globalization;

namespace Vetor1MediaDeAltura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de Alturas ?");

            int n = int.Parse(Console.ReadLine());

            double[] vet;

            vet = new double[n];


            for(int i = 0; i<n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for(int i=0; i<n; i++)
            {
                sum += vet[i];
            }

            double avg = sum / n;
            Console.WriteLine(" Alture Méda = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

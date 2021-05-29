using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 7 ");
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "domingo";
                    break;
                case 2:
                    day = "segunda";
                    break;
                case 3:
                    day = "terça";
                    break;
                case 4:
                    day = "quarta";
                    break;
                case 5:
                    day = "quinta";
                    break;
                case 6:
                    day = "sexta";
                    break;
                case 7:
                    day = "sabado";
                    break;
                default:
                    day = "valor invalido";
                    break;
            }
             Console.WriteLine(day);
        }
    }
}

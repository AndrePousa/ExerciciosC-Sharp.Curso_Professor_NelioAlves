using System;

namespace Demo1TratamentodeExceções
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Não é permitido divisão por 0");
            }
            catch(FormatException e)
            {
                Console.WriteLine(" Formato errado ! " + e.Message);
            }
        }
    }
}

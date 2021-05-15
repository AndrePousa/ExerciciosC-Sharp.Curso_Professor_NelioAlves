using System;

namespace FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); // apaga os espaços em branco da frente e de traz do string
            int n1 = original.IndexOf("bc"); //primeira ocorrencia
            int n2 = original.LastIndexOf("bc");//ultima ocorrencia
            string s4 = original.Substring(3); //corta a string a partir de um certo ponto//indice
            string s5 = original.Substring(3, 5); //começa a partir da posição 3 e corta 5 caracteres
            string s6 = original.Replace('a', 'x');// irá trocar os caracteres a por x 
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original); //testa se a string está vazia//usad em formulario
            bool b2 = String.IsNullOrWhiteSpace(original);//teste se há apenas espaço em branco

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: " + s1 + "-");
            Console.WriteLine("ToLower: " + s2 + "-");
            Console.WriteLine("Trim: " + s3 + "-");
            Console.WriteLine("IndexOf(bc): - " + n1 + "-");
            Console.WriteLine("LastIndexOf(bc): - " + n2 + "-");
            Console.WriteLine("Substring(3): - " + s4 + "-");
            Console.WriteLine("Substring(3,5): - " + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): - " + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): - " + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: - " + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: - " + b2 + "-");
        }
    }
}

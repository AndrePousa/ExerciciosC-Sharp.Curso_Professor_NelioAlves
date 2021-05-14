using System;
using System.Globalization;
namespace ExercicioProdutoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

            Console.WriteLine("Entre com os Dados do Produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no stoque:");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, quantidade);



            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao Estoque: ");
            quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.EntradanoEstoque(quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);

            Console.WriteLine();
            Console.Write("Digite o numero a ser removido do estoque:");
           
            quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.SaidadoEstoque(quantidade);

            Console.WriteLine("Dados atualizados " + p);









           












        }
    }
}

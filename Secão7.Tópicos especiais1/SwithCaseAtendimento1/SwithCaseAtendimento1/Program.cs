using System;

namespace SwithCaseAtendimento1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine("1--Desbloqueio do cartão");
            Console.WriteLine("2--Bloquear o cartão");
            Console.WriteLine("3--Reclamação do atendimento");
            Console.WriteLine("4--Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {



                case 1:
                    {
                        Console.WriteLine("Cartão desbloqueado");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Cartão bloqueado");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("sua ligação será transferida");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Obrigado pela sua ligação");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Não há essa opção");
                        break;
                    }

            }

               


        }
    }
}


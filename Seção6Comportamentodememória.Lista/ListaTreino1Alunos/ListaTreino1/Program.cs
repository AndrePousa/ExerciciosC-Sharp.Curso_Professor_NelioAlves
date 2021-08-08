using System;
using System.Collections.Generic;
using ListaTreino1.Entities;

namespace ListaTreino1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Quantos alunos você irá adicionar ? ");
            int n = int.Parse(Console.ReadLine());

            List<Aluno> list = new List<Aluno>();

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Id" + i + ": " );
               
                Console.Write("Nome: ");
                string nome = (Console.ReadLine());

                Console.Write("Nivel: ");
                string nivel = Console.ReadLine();
            
                list.Add(new Aluno(i, nome, nivel));
                         
                Console.WriteLine();

                Console.WriteLine(" Alunos adicionados:");
                
                foreach (Aluno obj in list)
                {
                    
                    Console.WriteLine(obj);
                }
            }

        }
    }
}

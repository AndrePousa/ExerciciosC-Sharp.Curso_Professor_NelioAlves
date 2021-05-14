using System;
using System.Collections.Generic;

namespace Aula_de_lista_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista declarada e instanciada
            List<string> list = new List<string>();

            //adicionando elementos na lista
            //função .Add, acrescenta elementos na lista
            //.Add por padrão adiciona ao final da lista
            //.insert posso definir a posição que quero colocar o elemento

            list.Add("maria");
            list.Add("Alex");
            list.Add("Paulo");
            list.Add("Satã");
            list.Add("Ana");
            //insere na posição 2 
            list.Insert(2, "Marco");

            //para cada string obj na lista, imprima na tela o obj
           foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
           //.Count,  mostra o tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            //Encontra na lista o primeiro ou último elementos da lista que sarisfaça um predicado
            //.Find , . FindLast
            //o .Find() espera uma função que faz um teste booleano
            string s1 = list.Find(Test);
            //Expressão Lambida
            //ou (x => x[0] == 'A');
            Console.WriteLine("First 'A':" + s1);

            //Espressão Lambida
            //busca o ultimo string com a Letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A':" + s2);

            //posição daquele que começa com A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            //Ultima posição daquele que começa com A
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição de quem começa com 'A' : " + pos2);

            //Filtrar a Lista com basse em um predicado
            //Criar uma lista com apenas os elementos que satisfaçam o predicado

            //Declarar uma lista que seja o resultado 
            //lista original dentro do FindAll(qualquer condição)
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------------------------------");

            //para cada string obj na list list2 mostra o obj
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //list.Remove(); remove elementos da lista

            //list.RemoveAll(); remove todos que satisfaçam o predicado

            //list.RemoveAtt(); remove pela posição

            //list.RemoveRang(); espera uma posição e uma contagem

        }
        
        //Função que retorna um boleano
        //Posso trocar a função por uma expressão lambida      
        static bool Test(string s) 
        {
            return s[0] == 'A';
        }
    }
}

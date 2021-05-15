using System;
using System.Collections.Generic;
using System.Text;

namespace Generics1
{
    class PrintServiceStrings
    {
        //variavel interna que pode armazanar 10 números inteiros
        private String[] _values = new string[10];
        //variavel interna para contar os números que eu adicionei
        private int _count = 0;

        //oprações
        //adicona o valor como algurmento dentro do vetor
        public void AddValue(string value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("O serviço de impressão já está cheio");
            }
            _values[_count] = value;
            _count++;
        }
        public string First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("O serviço de impressão está vazio");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}




using System;

namespace Generics1
{
    // classe que contém serviços de impressão. 
    class PrintService
    {   //variavel interna que pode armazanar 10 números inteiros
        private int[] _values = new int[10];
        //variavel interna para contar os números que eu adicionei
        private int _count = 0;

        //operações
        //adicona o valor como algurmento dentro do vetor
        public void AddValue(int value)
        {   
            if(_count == 10)
            {
                throw new InvalidOperationException("O serviço de impressão já está cheio");
            }
            _values[_count] = value;
            _count++;
        }
        public int First()
        {
            if(_count == 0)
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

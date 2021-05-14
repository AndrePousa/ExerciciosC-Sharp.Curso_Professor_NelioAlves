using System;
using System.Collections.Generic;


namespace Generics2.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("a lista não pode estar vazia");
            }
            //para encontar o maior da lista
            //salvei o primeiro elemento e procuro se há o maior 
            T max = list[0];
            for (int i = 0; i< list.Count; i++)
            {
                if(list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
                
            }
            return max;
        }
    }
}

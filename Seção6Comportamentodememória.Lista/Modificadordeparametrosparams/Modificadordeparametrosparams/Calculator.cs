using System;
using System.Collections.Generic;
using System.Text;

namespace Modificadordeparametrosparams
{
    class Calculator
    {     //função soma que recebe um vetor de numeros e calcula a soma dos numeros 

        // mantenho o padrão do vetor e coloco apenas a palavra parans atrá do tipo do vetor 
        // avisa o compilador que quero uma função que possa receber uma quantia variada de valores.
        public static int Sum(params int[] numbers)
        {  //Length pega o tamanho do vetor automaticamente
            int sum = 0;
            for( int i = 0; i < numbers.Length; i++) 
            {
                sum = +numbers[i];
            }
            return sum;
        }
            

         

    }
}

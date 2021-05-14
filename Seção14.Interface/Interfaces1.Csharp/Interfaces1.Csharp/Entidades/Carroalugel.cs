using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1.Csharp.Entidades
{
    class CarroAluguel
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Veiculo Veiculo { get; private set; }
        public Fatura Fatura { get; set; }

        public CarroAluguel(DateTime start, DateTime finish, Veiculo veiculo)
        {
            Start = start;
            Finish = finish;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
    
}

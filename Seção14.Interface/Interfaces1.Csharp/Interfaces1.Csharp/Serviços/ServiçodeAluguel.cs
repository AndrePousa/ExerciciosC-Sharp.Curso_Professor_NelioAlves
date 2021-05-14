using System;
using Interfaces1.Csharp.Entidades;

namespace Interfaces1.Csharp.Serviços
{
    class ServiçodeAluguel
    {
        public double PreçoPorHora { get; private set; }
        public double PreçoPorDia { get; private set; }

        private ITaxaServiço _taxaServiço;
      
        public ServiçodeAluguel(double preçoPorHora, double preçoPorDia, ITaxaServiço taxaServiço)
        {
            PreçoPorHora = preçoPorHora;
            PreçoPorDia = preçoPorDia;
            _taxaServiço = taxaServiço;
        }
        public void ProcessoFatura(CarroAluguel carroaluguel)
        {
            TimeSpan duração = carroaluguel.Finish.Subtract(carroaluguel.Start);

            double pagamentoBase = 0.0;
            if(duração.TotalHours <= 12.0)
            {
                pagamentoBase = PreçoPorHora * Math.Ceiling(duração.TotalHours);
            }
            else
            {
                pagamentoBase = PreçoPorDia * Math.Ceiling(duração.TotalDays);
            }
            double Taxa = _taxaServiço.Taxa(pagamentoBase);

            carroaluguel.Fatura = new Fatura(pagamentoBase, Taxa);
        }
    }
}

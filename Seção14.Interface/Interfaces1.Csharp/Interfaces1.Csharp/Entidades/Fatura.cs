using System.Globalization;


namespace Interfaces1.Csharp.Entidades
{
    class Fatura
    {
        public double PagamentoBase { get; set; }
        public double Taxa { get; set; }

        public Fatura(double aluguel, double taxa)
        {
            PagamentoBase = aluguel;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBase + Taxa; }
        }

        public override string ToString()
        {
            return "PagementoBase: "
                + PagamentoBase.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
               
        }
    }
}

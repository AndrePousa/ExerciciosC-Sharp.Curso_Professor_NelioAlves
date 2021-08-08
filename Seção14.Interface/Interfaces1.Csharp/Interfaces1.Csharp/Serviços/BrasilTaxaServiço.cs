namespace Interfaces1.Csharp.Serviços
{
    //Realização de interface
    class BrasilTaxaServiço : ITaxaServiço
    {
        public double Taxa(double quantidade)
        {
            if (quantidade <= 100.00)
            {
                return quantidade * 0.2;
            }
            else
            {
                return quantidade * 0.15;
            }
        }
    }

}

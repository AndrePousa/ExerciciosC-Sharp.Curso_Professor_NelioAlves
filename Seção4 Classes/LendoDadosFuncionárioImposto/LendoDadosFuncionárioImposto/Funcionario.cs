using System.Globalization;
namespace LendoDadosFuncionárioImposto

{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double Porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * Porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome + " , R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

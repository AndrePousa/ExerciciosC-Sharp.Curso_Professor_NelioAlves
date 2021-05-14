using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioProdutoEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void EntradanoEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void SaidadoEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override String ToString()
        {
            return Nome + " ,$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade
           + " unidade, Total: $ " + ValorTotalEmEstoque(). ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

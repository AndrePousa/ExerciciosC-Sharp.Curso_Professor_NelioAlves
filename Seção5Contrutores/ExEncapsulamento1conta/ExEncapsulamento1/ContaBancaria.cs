using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExEncapsulamento1
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //construtor com 2 argumentos
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0; //opcional
        }
        public ContaBancaria(int numero, string titular, double saldo)
            //reaproveitando o construtor com 2 argumentos
            : this(numero, titular)
        {
            Saldo = saldo;
        }
        //metodo Deposito.
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        //metodo Saque.
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
            //uma operação desconta a quantia e uma operação desconta a taxa.
            //ou Saldo -= 5.0; 
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

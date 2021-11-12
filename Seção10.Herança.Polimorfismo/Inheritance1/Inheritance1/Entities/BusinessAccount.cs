using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1.Entities
{
    //Herda da classe Accont
    class BusinessAccount : Account
    {
        //Atributo especifico da BusinesAccont
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        //Parametros de entrada no construtor da conta, acrescentando o Atributo da BusinessAccoun
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            :base (number, holder, balance) //Assim não preciso declarar o recebimento dos Atributos, Apenas da classe especializada
        {    // : extende, base(Argumentos de entrada da superclasse)
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}

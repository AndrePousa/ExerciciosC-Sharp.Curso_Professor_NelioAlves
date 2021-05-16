using System;

namespace Exercicio_do_Triangulo
{      //A classe é um tipo
    class Triangulo
    {   //atributos
        //Nome de Atributo começa com letra maiuscula
        public double A;
        public double B;
        public double C;

        //método para verificar a área
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}

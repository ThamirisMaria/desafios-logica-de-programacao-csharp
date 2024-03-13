using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    internal class CalculadoraDeOperacoesBasicas
    {
        private double valueOne { get; set; } = 0;
        private double valueTwo { get; set; } = 0;

        public CalculadoraDeOperacoesBasicas(double valueOne, double valueTwo)
        {
            this.valueOne = valueOne;
            this.valueTwo = valueTwo;
        }

        public double Somar()
        {
            return valueOne + valueTwo;
        }

        public double Subtrair()
        {
            return valueOne - valueTwo;
        }

        public double Multiplicar()
        {
            return valueOne * valueTwo;
        }

        public double Dividir()
        {
            return valueOne / valueTwo;
        }
    }
   
}

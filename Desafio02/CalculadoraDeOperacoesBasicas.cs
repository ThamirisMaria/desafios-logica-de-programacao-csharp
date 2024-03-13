using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    public class CalculadoraDeOperacoesBasicas(double valueOne, double valueTwo)
    {
        private double ValueOne { get; set; } = valueOne;
        private double ValueTwo { get; set; } = valueTwo;

        public double Somar()
        {
            return ValueOne + ValueTwo;
        }

        public double Subtrair()
        {
            return ValueOne - ValueTwo;
        }

        public double Multiplicar()
        {
            return ValueOne * ValueTwo;
        }

        public double Dividir()
        {
            if(ValueTwo == 0)
            {
                return 0;
            }
            return ValueOne / ValueTwo;
        }
    }
   
}

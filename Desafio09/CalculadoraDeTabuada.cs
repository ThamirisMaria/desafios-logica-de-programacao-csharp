using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio09
{
    public class CalculadoraDeTabuada(double numero)
    {
        private readonly double numero = numero;

        public List<double> CalcularTabuada()
        {
            List<double> tabuada = [];

            for (int i = 1; i <= 10; i++)
            {
                tabuada.Add(numero * i);
            }

            return tabuada;
        }
    }
}

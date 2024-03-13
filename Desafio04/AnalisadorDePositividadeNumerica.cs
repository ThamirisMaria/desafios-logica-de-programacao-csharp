using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    internal class AnalisadorDePositividadeNumerica
    {
        double number { get; set; } = 0;

        public AnalisadorDePositividadeNumerica(double number)
        {
            this.number = number;
        }

        public string getPositivoOuNegativo()
        {
            if (analisarPositividade())
            {
                return "POSITIVO";
            }

            return "NEGATIVO";
        }

        public bool analisarPositividade()
        {
            if(number == 0)
            {
                throw new ArgumentException("Zero não pode ser positivo ou negativo, informe um número válido!");
            }
            return number > 0;
        }
    }
}

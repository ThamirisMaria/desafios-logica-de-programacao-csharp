using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    public class AnalisadorDePositividadeNumerica(double number)
    {
        double Number { get; set; } = number;

        public string GetPositivoOuNegativo()
        {
            if (AnalisarPositividade())
            {
                return "POSITIVO";
            }

            return "NEGATIVO";
        }

        public bool AnalisarPositividade()
        {
            if(Number == 0)
            {
                throw new ArgumentException("Zero não pode ser positivo ou negativo, informe um número válido!");
            }
            return Number > 0;
        }
    }
}

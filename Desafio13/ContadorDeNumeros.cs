using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio13
{
    public class ContadorDeNumeros
    {
        //Dictionary<string, int> quantParesEImpares = new Dictionary<string, int>();
        //Dictionary<string, int> quantPositivosENegativos = new Dictionary<string, int>();

        private List<double> numeros;

        public ContadorDeNumeros(List<double> numeros)
        {
            this.numeros = numeros;
        }

        bool IsNumeroPar(double numero)
        {
            return numero % 2 == 0;
        }

        bool IsNumeroPositivo(double numero)
        {
            return numero > 0;
        }

        public Dictionary<string, int> GetQuantParesOuImpares()
        {
            int contadorPares = 0;
            int contadorImpares = 0;

            foreach (int numero in numeros)
            {
                if (IsNumeroPar(numero))
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }

            return new Dictionary<string, int> { { "Pares", contadorPares }, {"Impares", contadorImpares} };
        }

        public Dictionary<string, int> GetQuantPositivosOuNegativos()
        {
            int contadorPositivos = 0;
            int contadorNegativos = 0;

            foreach (int numero in numeros)
            {
                if (IsNumeroPositivo(numero))
                {
                    contadorPositivos++;
                }
                else
                {
                    contadorNegativos++;
                }
            }

            return new Dictionary<string, int> { { "Positivos", contadorPositivos }, {"Negativos", contadorNegativos} };
        }
    }
}

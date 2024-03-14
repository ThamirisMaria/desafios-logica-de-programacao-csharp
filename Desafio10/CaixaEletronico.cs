using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio10
{
    public class CaixaEletronico()
    {
        public Dictionary<int, int> Sacar(int valorSaque)
        {
            Dictionary<int, int> relacaoDeNotas = OtimizarEntregaDeCedulas(valorSaque);

            if (relacaoDeNotas == null)
            {
                throw new ArgumentException("Não é possível sacar o valor informado com as cédulas disponíveis.");
            }

            return relacaoDeNotas;
        }


        public static Dictionary<int, int> OtimizarEntregaDeCedulas(int valor)
        {
            int[] valoresNotas = { 200, 100, 50, 20, 10, 5, 2 };
            Dictionary<int, int> relacaoDeNotas = new Dictionary<int, int>();

            int restante = valor;
            foreach (int nota in valoresNotas)
            {
                if (restante >= nota)
                {
                    int quantidadeNotas = restante / nota;
                    relacaoDeNotas.Add(nota, quantidadeNotas);
                    restante %= nota;
                }
            }

            if (restante == 0)
            {
                return relacaoDeNotas;
            }
            else
            {
                return null;
            }
        }
    }
}

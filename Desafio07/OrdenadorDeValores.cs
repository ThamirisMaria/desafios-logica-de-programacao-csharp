using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio07
{
    public class OrdenadorDeValores
    {
        private List<double> valores;
        public List<double> Valores { get { return valores; } }

        public OrdenadorDeValores()
        {
            valores = new List<double>();
        }

        public List<double> GetValoresEmOrdemCrescente()
        {
            return valores.OrderBy(valor => valor).ToList();
        }

    }
}

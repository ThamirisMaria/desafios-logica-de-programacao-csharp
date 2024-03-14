using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    public class Jogo(int horaInicial, int horaFinal)
    {

        public int GetDuracao()
        {
            if (horaFinal > horaInicial)
            {
                return horaFinal - horaInicial;
            }
            else
            {
                return 24 - horaInicial + horaFinal;
            }
        }
    }
}

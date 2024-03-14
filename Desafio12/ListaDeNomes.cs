using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio12
{
    public class ListaDeNomes(List<string> nomes)
    {
        private readonly List<string> nomes = nomes;

        public bool ProcurarNome(string nomeParaProcurar)
        {
           return nomes.Exists(nome => nome.Equals(nomeParaProcurar, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}

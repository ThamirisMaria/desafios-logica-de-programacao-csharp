using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03
{
    public class CalculadoraPagamentoDeCorretores(double salarioFixo, double totalDeVendas, double percentualComissao)
    {
        double SalarioFixo { get; set; } = salarioFixo;
        double TotalDeVendas { get; set; } = totalDeVendas;
        double PercentualComissao { get; set; } = percentualComissao;

        public double CalcularPagamentoTotal()
        {
            return SalarioFixo + TotalDeVendas * (PercentualComissao/100);
        }
    }
}

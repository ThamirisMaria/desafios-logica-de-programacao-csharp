/*
 * Uma imobiliária paga aos seus corretores um salário fixo por mês 
 * e uma porcentagem de comissão de acordo com o valor de vendas realizadas. 
 * Crie um sistema para calcular a soma do salário + a comissão recebida em relação às vendas.
 * 
 * - Entradas:
 *      Valor do salário fixo
 *      Total de vendas
 *      Percentual de comissão acordado
 * - Saídas:
 *      Valor total a receber
 *
 *  Nota: Esse programa deve funcionar para diferentes imobiliárias, ou seja, 
 *  deve ser possível modificar os valores de entrada e ter o cálculo sendo feito de forma correta.
 */
using Desafio03;
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Calculadora de Pagamento de Corretores");
tituloDoDesafio.MostrarTituloDoDesafio();

Console.Write("Insira o salário fixo: ");
double salarioFixo = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira o total de vendas: ");
double totalDeVendas =  Convert.ToDouble(Console.ReadLine());
Console.Write("Insira o percentual de comissão: ");
double percentualDeComissao =  Convert.ToDouble(Console.ReadLine());

CalculadoraPagamentoDeCorretores calculadoraPagamentoDeCorretores = new(salarioFixo, totalDeVendas, percentualDeComissao);

Console.WriteLine("Valor total a receber: ");
Console.WriteLine($"R${calculadoraPagamentoDeCorretores.CalcularPagamentoTotal()}");
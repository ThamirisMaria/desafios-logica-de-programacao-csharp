/*
 * Elabore um programa que receba três valores como entrada, e mostre todos na saída em ordem crescente.
 */

using Desafio07;
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Ordenador De Valores");
tituloDoDesafio.MostrarTituloDoDesafio();

OrdenadorDeValores ordenador = new();

for(int i = 1; i <= 3; i++)
{
    Console.Write($"Digite o {i}º valor: ");
    ordenador.Valores.Add(Convert.ToDouble(Console.ReadLine()));
}

List<double> valoresEmOrdemCrescente = ordenador.GetValoresEmOrdemCrescente();

Console.WriteLine("Valores ordenados em ordem crescente:");
foreach(double valor in valoresEmOrdemCrescente)
{
    Console.WriteLine(valor);
}

/*
 * Crie um algoritmo que tem como entrada um número e imprime a sua tabuada do 1 ao 10.
 */
using Desafio09;
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Calculadora de Tabuada");
tituloDoDesafio.MostrarTituloDoDesafio();

Console.WriteLine("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

CalculadoraDeTabuada calculadoraDeTabuada = new(numero);
List<double> tabuada = calculadoraDeTabuada.CalcularTabuada();

Console.WriteLine($"\nTabuada do número {numero}:\n");
for (int i = 0; i < tabuada.Count; i++)
{
    Console.WriteLine($"{numero} * {i+1} = {tabuada[i]}");
}
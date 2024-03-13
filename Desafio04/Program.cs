
/*
* Crie um programa que analise se o valor de uma variável é positivo ou negativo, mostrando essa informação na tela.
*/

using Desafio04;
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Calculadora de Operações Básicas");
tituloDoDesafio.MostrarTituloDoDesafio();


Console.Write("Digite um número: ");
double number = Convert.ToDouble(Console.ReadLine());

AnalisadorDePositividadeNumerica analisador = new(number);

try
{
    string positivoOuNegativo;
    positivoOuNegativo = analisador.GetPositivoOuNegativo();
    Console.WriteLine($"\nO número {number} é {positivoOuNegativo}");
}
catch(ArgumentException e)
{
    Console.WriteLine("\n" + e.Message);
}

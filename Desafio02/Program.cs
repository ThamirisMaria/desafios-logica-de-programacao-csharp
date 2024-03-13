
/*
 Faça um programa que armazene em duas variáveis distintas dois valores distintos: 
 valueOne e valueTwo. Após, apresente os seguintes cálculos:

    Soma
    Substração
    Multiplicação
    Divisão
*/

using Desafio02;
using Helpers;

TituloDoDesafio tituloDoDesafio = new TituloDoDesafio("Calculadora de Operações Básicas");
tituloDoDesafio.MostrarTituloDoDesafio();

Console.Write("Digite o primeiro valor: ");
double valueOne = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
double valueTwo = Convert.ToDouble(Console.ReadLine());

CalculadoraDeOperacoesBasicas calculadora = new CalculadoraDeOperacoesBasicas(valueOne, valueTwo);

Console.WriteLine("\nCálculos: \n");

Console.WriteLine($"Soma: {valueOne} + {valueTwo} = {calculadora.Somar()}");
Console.WriteLine($"Subtração: {valueOne} - {valueTwo} = {calculadora.Subtrair()}");
Console.WriteLine($"Multiplicação: {valueOne} * {valueTwo} = {calculadora.Multiplicar()}");
Console.WriteLine($"Divisão: {valueOne} / {valueTwo} = {calculadora.Dividir()}");

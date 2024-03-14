/*
 * Escreva um algoritmo que receba como entrada três números que serão armazenados nas variáveis valueOne, 
 * valueTwo e valueThree respectivamente. Tendo esses valores, mostre-os na tela na ordem em que estão armazenados. 
 * Mostre também, as trocas, em que ao final valueTwo assuma o valor de valueThree, 
 * valueThree assuma o valor de valueOne e valueOne assuma o valor de valueTwo.
 */
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Calculadora de Operações Básicas");
tituloDoDesafio.MostrarTituloDoDesafio();


Console.WriteLine("Digite o primeiro valor:");
int valueOne = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o segundo valor:");
int valueTwo = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite o terceiro valor:");
int valueThree = int.Parse(Console.ReadLine()!);

Console.WriteLine("Valores na ordem original:");
Console.WriteLine($"Valor 1: {valueOne}");
Console.WriteLine($"Valor 2: {valueTwo}");
Console.WriteLine($"Valor 3: {valueThree}");

Trocar();

Console.WriteLine("\nValores após a troca:");
Console.WriteLine($"Valor 1: {valueOne}");
Console.WriteLine($"Valor 2: {valueTwo}");
Console.WriteLine($"Valor 3: {valueThree}");

void Trocar()
{
    int temp = valueTwo;
    valueTwo = valueThree;
    valueThree = valueOne;
    valueOne = temp;
}
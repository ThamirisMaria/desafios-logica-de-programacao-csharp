/*
 * Dado um array de números, mostre quantos valores são pares, 
 * quantos são ímpares, quantos são positivos e quantos são negativos.
 */

using Desafio13;
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Contador de números");
tituloDoDesafio.MostrarTituloDoDesafio();

List<double> numeros = new();

bool continuar = true;
while (continuar)
{
    Console.WriteLine("Digite um número para adicionar à lista, ou S para sair: ");
    string input = Console.ReadLine()!;

    if(input == "s" || input == "S")
    {
        continuar = false;
    }
    else
    {
        numeros.Add(Convert.ToDouble(input));
        Console.Clear();
    }
    Console.Clear() ;
}

ContadorDeNumeros contadorDeNumeros = new(numeros);

Console.WriteLine("\nQuantidade de:\n");
Console.WriteLine($"{contadorDeNumeros.GetQuantParesOuImpares().First().Key}: {contadorDeNumeros.GetQuantParesOuImpares().First().Value}");
Console.WriteLine($"{contadorDeNumeros.GetQuantParesOuImpares().ElementAt(1).Key}: {contadorDeNumeros.GetQuantParesOuImpares().ElementAt(1).Value}");
Console.WriteLine($"{contadorDeNumeros.GetQuantPositivosOuNegativos().First().Key}: {contadorDeNumeros.GetQuantPositivosOuNegativos().First().Value}");
Console.WriteLine($"{contadorDeNumeros.GetQuantPositivosOuNegativos().ElementAt(1).Key}: {contadorDeNumeros.GetQuantPositivosOuNegativos().ElementAt(1).Value}");

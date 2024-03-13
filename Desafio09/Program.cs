/*
 * Crie um algoritmo que tem como entrada um número e imprime a sua tabuada do 1 ao 10.
 */
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Calculadora de Tabuada");
tituloDoDesafio.MostrarTituloDoDesafio();

Console.WriteLine("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

List<double> tabuada = CalcularTabuada(numero);

Console.WriteLine($"\nTabuada do número {numero}:\n");

for (int i = 0; i < tabuada.Count; i++)
{
    Console.WriteLine($"{numero} * {i+1} = {tabuada[i]}");
}

static List<double> CalcularTabuada(double numero)
{
    List<double> tabuada = [];

    for (int i = 1; i <= 10; i++)
    {
        tabuada.Add(numero*i);
    }

    return tabuada;
}
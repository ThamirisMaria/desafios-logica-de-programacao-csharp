/*
 * Repita o Desafio 2, agora permitindo ao usuário que ele escolha qual cálculo ele deseja executar.
 */
using Desafio02;
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Calculadora de Operações Básicas 02");
tituloDoDesafio.MostrarTituloDoDesafio();

Console.Write("Digite o primeiro valor: ");
double valueOne = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
double valueTwo = Convert.ToDouble(Console.ReadLine());

CalculadoraDeOperacoesBasicas calculadora = new(valueOne, valueTwo);

bool continuar = true;
while (continuar)
{
    Console.WriteLine("\nDigite o número do cálculo desejado, ou s para sair: \n");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("S - Sair");

    string opcao = Console.ReadLine()!;

    Console.Clear();
    Console.WriteLine("Resultado: ");
    switch (opcao)
    {   
        case "1": 
            Console.WriteLine($"Soma: {valueOne} + {valueTwo} = {calculadora.Somar()}");
            break;
        case "2": 
            Console.WriteLine($"Subtração: {valueOne} - {valueTwo} = {calculadora.Subtrair()}");
            break;
        case "3": 
            Console.WriteLine($"Multiplicação: {valueOne} * {valueTwo} = {calculadora.Multiplicar()}");
            break;
        case "4":
            Console.WriteLine($"Divisão: {valueOne} / {valueTwo} = {calculadora.Dividir()}");
            break;
        case "S":
        case "s":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Thread.Sleep(2000);
}
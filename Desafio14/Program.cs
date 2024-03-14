/*
 * Dado um array de números, faça um programa que tenha um menu de opções para que o usuário possa:
 * 
 * - Adicionar um novo número no final do array
 * - Remover um número do array baseado em posição
 * - Remover um número do array baseado no seu valor (removendo todas as ocorrências se houver mais de uma)
 * - Ordenar os números em ordem crescente
 * - Ordenar os números em ordem decrescente
 * - Somar os valores do array
 */

using Helpers;

TituloDoDesafio tituloDoDesafio = new("Manipulação de arrays");
tituloDoDesafio.MostrarTituloDoDesafio();

List<int> numeros = new List<int>();


while (true)
{
    Console.WriteLine($"Array inicial: [{string.Join(", ", numeros)}]\n");

    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Adicionar número");
    Console.WriteLine("2 - Remover número por posição");
    Console.WriteLine("3 - Remover número por valor");
    Console.WriteLine("4 - Ordenar em ordem crescente");
    Console.WriteLine("5 - Ordenar em ordem decrescente");
    Console.WriteLine("6 - Somar os valores");
    Console.WriteLine("-1 - Sair");

    Console.Write("\nEscolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case -1:
            Console.WriteLine("\nSaindo...");
            return;
        case 1:
            Console.Write("\nDigite o número a ser adicionado: ");
            int numero = int.Parse(Console.ReadLine()!);
            AdicionarNumero(numeros, numero);
            break;
        case 2:
            Console.Write("\nDigite a posição do número a ser removido: ");
            int posicao = int.Parse(Console.ReadLine()!);
            RemoverPorPosicao(numeros, posicao);
            break;
        case 3:
            Console.Write("\nDigite o número a ser removido: ");
            int valor = int.Parse(Console.ReadLine()!);
            RemoverPorValor(numeros, valor);
            break;
        case 4:
            OrdenarCrescente(numeros);
            break;
        case 5:
            OrdenarDecrescente(numeros);
            break;
        case 6:
            int soma = SomarNumeros(numeros);
            Console.WriteLine($"\nA soma dos valores é: {soma}");
            break;
        default:
            Console.WriteLine("\nOpção inválida. Tente novamente.");
            break;
    }

    Console.WriteLine($"\nArray atualizado: [{string.Join(", ", numeros)}]\n");
    Thread.Sleep(2000);
    Console.Clear();
}

static void AdicionarNumero(List<int> lista, int numero)
{
    lista.Add(numero);
}

static void RemoverPorPosicao(List<int> lista, int posicao)
{
    if (posicao >= 0 && posicao < lista.Count)
    {
        lista.RemoveAt(posicao);
    }
    else
    {
        Console.WriteLine("Posição inválida.");
    }
}

static void RemoverPorValor(List<int> lista, int valor)
{
    lista.RemoveAll(x => x == valor);
}

static void OrdenarCrescente(List<int> lista)
{
    lista.Sort();
}

static void OrdenarDecrescente(List<int> lista)
{
    lista.Sort();
    lista.Reverse();
}

static int SomarNumeros(List<int> lista)
{
    int soma = 0;
    foreach (int numero in lista)
    {
        soma += numero;
    }
    return soma;
}
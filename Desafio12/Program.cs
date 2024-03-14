/*
 * Dado um array de nomes, faça um programa que tenha como entrada uma expressão textual
 * a ser pesquisada e retorne se o nome existe ou não no array.
 */
using Desafio12;
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Lista de nomes");
tituloDoDesafio.MostrarTituloDoDesafio();

List<string> nomes = [];

bool continuar = true;
while (continuar)
{
    Console.WriteLine("Digite um nome para adicionar à lista, ou S para sair: ");
    string input = Console.ReadLine()!;

    if (input == "s" || input == "S")
    {
        continuar = false;
    }
    else
    {
        nomes.Add(input);
        Console.Clear();
    }
    Console.Clear();
}

ListaDeNomes listaDeNomes = new(nomes);

Console.Write("Digite um nome para pesquisar: ");
string nome =  Console.ReadLine()!;

if (listaDeNomes.ProcurarNome(nome))
{
    Console.WriteLine($"O nome {nome} existe!");
}
else
{
    Console.WriteLine($"O nome {nome} não existe!");
}
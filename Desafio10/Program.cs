/*
 * Desenvolva um método estático de saque de caixa eletrônico.
 * 
 * O usuário deve informar um valor desejado de saque como entrada, 
 * e esse valor deve ser passado para o método de saque.
 * 
 * - O método de saque deve implementar um algoritmo de otimização de entrega de cédulas, 
 *      calculando o menor número possível de cédulas no qual o valor pode ser decomposto. 
 * - O método deve retornar a relação de cédulas para o invocador.
 * - As notas consideradas são de (R$) 200, 100, 50, 20, 10, 5 e 2.
 * - A relação de cédulas deve ser impressa.
 */

using Desafio10;
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Otimização  de Entrega de Cédulas");
tituloDoDesafio.MostrarTituloDoDesafio();

CaixaEletronico caixaEletronico = new();

Console.Write("Insira o valor para saque: ");
int valorSaque = int.Parse(Console.ReadLine()!);


try
{
    Dictionary<int, int> relacaoDeNotas  = caixaEletronico.Sacar(valorSaque);

    Console.Clear();

    Console.WriteLine($"Relação de cédulas para sacar R${valorSaque}:\n");
    foreach (KeyValuePair<int, int> nota in relacaoDeNotas)
    {
        Console.WriteLine($"Cédula de {nota.Key}:\n Quantidade: {nota.Value}\n");
    }
}
catch (ArgumentException e) 
{ 
    Console.WriteLine(e.Message);
}



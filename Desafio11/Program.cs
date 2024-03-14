/*
 * Crie um método estático que recebe como argumento um valor em segundos, 
 * calcula e retorna ao invocador uma string formatada HH:MM:SS (horas:minutos:segundos).
 */

using Helpers;

TituloDoDesafio tituloDoDesafio = new("Conversor de segundos em horas");
tituloDoDesafio.MostrarTituloDoDesafio();

Console.Write("Informe os segundos: ");
int segundos = int.Parse(Console.ReadLine()!);
string tempoFormatado = ConverterParaHora(segundos);
Console.WriteLine($"\nTempo formatado: {tempoFormatado}");

static string ConverterParaHora(int segundos)
{
    int horas = segundos / 3600;
    int minutos = (segundos % 3600) / 60;
    int segundosRestantes = segundos % 60;

    string tempoFormatado = $"{horas:D2}:{minutos:D2}:{segundosRestantes:D2}";

    return tempoFormatado;
}
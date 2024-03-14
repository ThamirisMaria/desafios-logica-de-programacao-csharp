/*
 * Faça um programa que receberá a hora inicial e a hora final de um jogo. 
 * A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro 
 * (com duração máxima de 24 horas).
 * 
 * Nota: Um jogo tem somente horas "em ponto" - Não é necessário trabalhar com minutos e segundos.
 */
using Desafio05;
using Helpers;

TituloDoDesafio tituloDoDesafio = new("Duração do Jogo");
tituloDoDesafio.MostrarTituloDoDesafio();

Console.Write("Insira a hora de início do jogo: ");
int horaInicial = int.Parse(Console.ReadLine()!);

Console.Write("Insira a hora de encerramento do jogo: ");
int horaFinal = int.Parse(Console.ReadLine()!);

Jogo jogo = new(horaInicial, horaFinal);

Console.WriteLine($"\nA duração do jogo foi de {jogo.GetDuracao()} horas.");
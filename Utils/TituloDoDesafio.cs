namespace Helpers;
using System;

public class TituloDoDesafio
{
	string tituloDoDesafio = string.Empty;

	public TituloDoDesafio(string tituloDoDesafio)
	{
		this.tituloDoDesafio = tituloDoDesafio;
	}

	public void MostrarTituloDoDesafio()
	{
        int quantidadeDeLetras = tituloDoDesafio.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

        Console.WriteLine(asteriscos);
        Console.WriteLine(tituloDoDesafio);
        Console.WriteLine(asteriscos + "\n");
    }
}

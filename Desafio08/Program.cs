/*
 * Realize as seguintes sequências de impressões:
 *  1 - Utilize while para imprimir os valores de 1 até 25.
 *  2 - Utilize for para imprimir os valores de 10 até 200, pulando de 10 em 10.
 */
void ImprimirValores1a25()
{
    Console.WriteLine("Valores de 1 até 25: ");

    int valor = 1;
    while (valor<=25)
    {
        Console.WriteLine(valor);
        valor += 1;
    }
}

void ImprimirValores10a200()
{
    Console.WriteLine("Valores de 10 até 200, de 10 em 10: ");

    for (int i = 10; i <= 200; i = i+10)
    {
        Console.WriteLine(i);
    }
}

ImprimirValores1a25();
Thread.Sleep(2000);
Console.Write("\n");
ImprimirValores10a200();
int numero;
int pares = 0;

Console.WriteLine("ingrese números (0 para detener)");

do
{
    Console.WriteLine("ingrese número");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0 && numero % 2 == 0)
    {
        pares++;
    }

} while (numero != 0);

Console.WriteLine($"Cantidad de números pares: {pares}");
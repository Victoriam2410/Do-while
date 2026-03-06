int numero;
double suma = 0;
int cantidad = 0;
double promedio = 0;

Console.WriteLine("ingrese números (0 para detener)");

do
{
    Console.WriteLine("ingrese numero");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0)
    {
        suma = suma + numero;
        cantidad = cantidad + 1;
    }

} while (numero != 0);

if (cantidad > 0)
{
    promedio = suma / cantidad;
}

Console.WriteLine($"suma total: {suma}");
Console.WriteLine($"cantidad de números: {cantidad}");
Console.WriteLine($"promedio: {promedio}");
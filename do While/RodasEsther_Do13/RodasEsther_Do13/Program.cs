int numero;
int x = 0;
Console.WriteLine("ingrese cualquier numero (0 para detener)");
do
{
    Console.WriteLine("ingrese numero");
    numero = int.Parse(Console.ReadLine());
    x++;
} while (numero != 0);
Console.WriteLine($"los numeros que ingreso son: {x}");
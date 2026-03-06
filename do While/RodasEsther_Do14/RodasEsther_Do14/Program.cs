int numero;
int mayor;

Console.WriteLine("ingrese cualquier numero (0 para detener)");
numero = int.Parse(Console.ReadLine());
mayor = numero;

while (numero != 0)
{
    if (numero > mayor)
    {
        mayor = numero;
    }
    Console.WriteLine("ingrese numero");
    numero = int.Parse(Console.ReadLine());
}

Console.WriteLine($"El número mayor es: {mayor}");
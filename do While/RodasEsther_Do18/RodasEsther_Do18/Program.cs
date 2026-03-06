int opcion;

do
{
    Console.WriteLine("1 Mostrar saludo");
    Console.WriteLine("2 Mostrar número aleatorio");
    Console.WriteLine("0 Salir");

    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("Hola, bienvenido.");
    }
    if (opcion == 2)
    {
        Console.WriteLine("Número generado: 42");
    }

} while (opcion != 0);
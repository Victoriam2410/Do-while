int numero;
int x = 0;
int suma = 0;
Console.WriteLine("ingrese 5 numeros (0 para detener)");
do
{
        Console.WriteLine("ingrese numero");
        numero = int.Parse(Console.ReadLine());
    suma += numero;
    x++;
} while (numero !=0);
Console.WriteLine($"la suma es: {suma}");
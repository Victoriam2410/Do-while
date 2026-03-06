int numero = 1;
int suma = 0;
do
{
    suma += numero;
    Console.WriteLine($"{numero}");
    numero++;
} while (numero <= 10);
Console.WriteLine($"la suma es: {suma}");
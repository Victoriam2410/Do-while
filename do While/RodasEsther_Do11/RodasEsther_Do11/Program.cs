int numero;
int suma = 0;
int x = 1;
do
{
    Console.WriteLine("ingrese numero");
    numero = int.Parse(Console.ReadLine());
    suma += numero;
    x++;    
} while ( x <= 5);
Console.WriteLine($"la suma de los numeros es : {suma}");
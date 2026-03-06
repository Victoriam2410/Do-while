int numero;
int contador = 1;

Console.WriteLine("Ingrese un número para ver su tabla:");
numero = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
} while (contador <= 10);
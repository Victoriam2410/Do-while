int numero;
int x = 0;
do
{
    Console.WriteLine("ingrese numero positivo");
    numero = int.Parse(Console.ReadLine());
    x++;
} while (numero < 0);
Console.WriteLine("numero valido");
string pass;
int x = 0;
do
{
    Console.WriteLine("ingrese contraseña");
    pass = Console.ReadLine();
    x++;
} while (pass != "2410");
Console.WriteLine("contraseña correcta");

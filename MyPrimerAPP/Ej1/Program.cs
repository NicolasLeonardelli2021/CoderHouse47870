// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese Edad");

short edad = 0;
edad = Convert.ToInt16(Console.ReadLine());

if(edad > 18)
{
    Console.WriteLine("Es mayor de edad");
}

Console.ReadKey();


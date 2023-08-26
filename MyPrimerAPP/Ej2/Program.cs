// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Ingresar Nota");

short nota = 0;

nota = Convert.ToInt16(Console.ReadLine());

if(nota >= 7)
{
    Console.WriteLine("Aprobó");
}
else
{
    Console.WriteLine("Reprobo");
}

Console.ReadKey();
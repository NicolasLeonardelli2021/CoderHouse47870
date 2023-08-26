// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

short num1 = 0;
short num2 = 0;

Console.WriteLine("Ingresar Num 1");
num1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Ingresar Num 2");
num2 = Convert.ToInt16(Console.ReadLine());

int suma = num1 + num2;
int multiplicacion = num1 * num2;
float division  = num1 / num2;
int resta =  num1 - num2;

if(multiplicacion > 20)
{
    multiplicacion -= resta;
}
else
{
    multiplicacion += suma;
}

Console.WriteLine(multiplicacion);

Console.ReadKey();
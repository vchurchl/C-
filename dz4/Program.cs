// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max=a;

if (b > max && b > c)
{
   max=b;
   Console.WriteLine ($"Максимальное {max}");
}
else
{
    if (c > max)
    {
    max=c;
    Console.Write ($"Максимальное {max}");
    }
    else 
    {
    max=a;
    Console.Write ($"Максимальное {max}");
    }
}



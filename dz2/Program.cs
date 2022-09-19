// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
   Console.Write($"Число {a} большее, число {b} меньшеe");
}
else
{
    Console.Write($"Число {a} меньшее, число {b} большее");
}
﻿// На входе принимает число и выдает его квадрат


Console.Clear();
Console.Write("Привет! Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;
Console.WriteLine($"Квадрат числа {num}: {result}");

if (num==result)
{
   Console.Write("1"); 
}
else
{
    Console.Write("2");
}
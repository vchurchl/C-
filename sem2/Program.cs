// напишите программу, которая  выводит случайное число из отрезка [10,99] т показывает наибольшую цифру числа

Console.Clear();

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num1 = num/100;
int num2 = num % 10;
int result = num1*10+num2;
Console.WriteLine(result);
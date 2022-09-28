//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
int[] num = new int[5];
    for(int i = 0; i < num.Length; i++)
    {
    Console.Write($"Введите число: ");
    num[i] = Convert.ToInt32(Console.ReadLine());
    }
// Console.Write("Вывод массива:" );
//     for(int i = 0; i < num.Length; i++)
//     {
//     Console.Write(num[i]);
//     }

if((num[0]==num[4]) && (num[1]==num[3])) 
{
    Console.Write("Введенное число - палиндром");
}
else
{
    Console.Write("Введенное число - не палиндром");
}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//AB = √(x1 - x2)2 + (y1 - y2)2 + (z1 - z2)2

// Console.Clear();
// Console.Write("Введите координату x для точки А: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y для точки А: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z для точки А: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату x для точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y для точки B: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y для точки B: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double s = Math.Round(Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),2);
// Console.Write(s);


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i < n + 1; i++)
// Console.Write($"{Math.Pow(i,3)} ");


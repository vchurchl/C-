// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//Console.Clear();
//int num = new Random().Next(100,1000);
//Console.WriteLine(num);
//int num1 = num/10;
//Console.WriteLine(num1);
//int num2 = num1 % 10;
//Console.WriteLine(num2);
//int result = num2;
//Console.WriteLine(result);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Console.Clear();
//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num < 100)
//{
//    Console.WriteLine("третьей цифры нет");
//}
//else
//{
//    int num1 = num/100;
//    int num2 = num % 10;
//    int result = num2;
//    Console.WriteLine(result);
//}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.Clear();
Console.Write("Введите номер дня недели от 1-7, где 1 - это понедельник, 7 - воскресенье: ");
int num = Convert.ToInt32(Console.ReadLine());;

if(num > 7)
{
   Console.Write("Неверно указан номер дня недели.Введите номер от 1-7, где 1 - это понедельник, 7 - воскресенье: "); 
}
else
{
    if((num == 7) || (num == 6))
        {
            Console.WriteLine("Да"); 
        }
    else
        {
            Console.WriteLine("Нет");
        }
}
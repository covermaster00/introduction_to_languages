﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Задача 10. Введите трехзначное число: ");
Console.WriteLine("Вторая цифра вашего числа: " + Console.ReadLine()[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Задача 13. Введите положительное число: ");
string anyNumber = Console.ReadLine();
if (anyNumber.Length > 2) Console.WriteLine("Третья цифра вашего числа: " + anyNumber[2]);
else Console.WriteLine("Число не имеет третье цифры");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool IsWeekend (int day) 
{
  return (day == 6 || day == 7);
}

Console.Write("Введите цифру, обозначающую день недели: ");
Console.Write("Алиса, этот день - выходной? " + IsWeekend (Convert.ToInt32(Console.ReadLine())));
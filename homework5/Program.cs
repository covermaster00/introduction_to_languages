void PrintArrayInt(string message, int[] array)
{
    Console.Write(message + "[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

void PrintArrayDouble(string message, double[] array)
{
    Console.Write(message + "[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void RndArrayInt(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int[] arrayInt = new int[10];
RndArrayInt(arrayInt);
PrintArrayInt("Исходный массив Int: ", arrayInt);

int count = 0;  // Задача 34
int sum = 0;    // Задача 36

for (int i = 0; i < arrayInt.Length; i++)
{
  if (arrayInt[i] % 2 == 0) count++;
  if (i % 2 ==0 ) sum += arrayInt[i];
}

Console.WriteLine("В массиве " + count + " четных чисел");
Console.WriteLine("Сумма элементов на нечётных позициях массива = " + sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void RndArrayDouble(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

double[] arrayDouble = new double[10];
RndArrayDouble(arrayDouble);
PrintArrayDouble("Исходный массив Double: ", arrayDouble);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < arrayDouble.Length; i++)
{
    if (arrayDouble[i] > max) max = arrayDouble[i];
    if (arrayDouble[i] < min) min = arrayDouble[i];
}

Console.WriteLine("Максимальное значение = " + max + ", минимальное значение = " + min);
Console.WriteLine("max - min = " + Math.Round((max - min), 2));

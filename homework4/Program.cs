// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exp(int A, int B)
{
  int result = 1;
  for(int i = 1; i <= B; i++)
    result = result * A;
  return result;
}

  Console.Write("Введите число: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите степень для числа: ");
  int B = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("А^B = " + Exp(A, B));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Summa(int N)
{
  int temp = 0;
  int result = 0;
  for (int i = 0; i < Convert.ToString(N).Length; i++)
  {
    temp = N - N % 10;
    result = result + (N - temp);
    N = N / 10;
  }
  return result;
}

Console.WriteLine("Сумма цифр в числе: " + Summa(N));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Random rnd = new Random();
int[] mass = new int[8];
Console.Write("Создан массив: [");
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rnd.Next();
    Console.Write(mass[i]);
    if (i + 1 < mass.Length) Console.Write(", ");
}
Console.WriteLine("]");
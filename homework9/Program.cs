// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int N = 12;

int GetNatural(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write(GetNatural(n, m + 1) + ", ");
    return m;
}

Console.Write("Задача 64. N = 12. Последовательность: ");
Console.WriteLine(GetNatural(N, 1));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

N = 15;
int M = 5;

int NaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + NaturalSum(m, n - 1);
}

Console.WriteLine("Задача 66. Сумма натуральных элементов от " + M + " до " + N + " = " + NaturalSum(M, N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

N = 2;
M = 2;
Console.WriteLine("Задача 68. Функция Аккерамана для " + M + " и " + N + " = " + Akkerman(M, N));


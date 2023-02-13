// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());

if (x1 > x2) Console.WriteLine(x1 + " больше " + x2);
else Console.WriteLine(x2 + " больше " + x1);


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. (Сравнить с каждым)

Console.Write("Введите первое число: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int m2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int m3 = Convert.ToInt32(Console.ReadLine());

int max = m1;
if(m2 > max) max = m2;
if(m3 > max) max = m3;

Console.WriteLine("Максимальное число это " + max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");

if(Convert.ToInt32(Console.ReadLine()) % 2 == 0) Console.WriteLine("Это число четное");
else Console.WriteLine("Это число нечетное");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int even = 2;

if(n > 1)
    while(even <= n)
    {
        Console.Write(even + " ");
        even += 2;
    }
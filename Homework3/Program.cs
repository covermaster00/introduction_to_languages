// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool isPalindrom (string number)
{
    return (number[0]==number[4]) && (number[1]==number[3]);
}

Console.WriteLine("Задача 19");
Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
  if (isPalindrom (number)) Console.WriteLine("Число " + number + " - палиндром");
  else Console.WriteLine("Число " + number + " - не палиндром");
}
else Console.WriteLine("Введены данные не удовлетворяющее условию задачи");


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double distance (int[] a, int[] b)
{
    return Math.Sqrt(Math.Pow((b[0]-a[0]), 2) + Math.Pow((b[1]-a[1]), 2) + Math.Pow((b[2]-a[2]), 2));
}    

Random rnd = new Random();
int[] a = new int[3] {rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100, 100)};
int[] b = new int[3] {rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100, 100)};

Console.WriteLine("Задача 21");
Console.WriteLine("Расстояние между точками A (" + a[0] + ", " + a[1] + ", " + a[2] + ") и B (" + b[0] + ", " + b[1] + ", " + b[2] + ") равно " + distance(a, b));


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Задача 23");
Console.Write("Введите число: ");
double n =  Convert.ToDouble(Console.ReadLine());

if (n > 0)
    for (int i = 1; i <= n; i++)
    {
        Console.Write((i * i * i) + " ");
    }
else 
    for (int i = 1; i >= n; i--)
    {
        Console.Write((i * i * i) + " ");
    }

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

void PrintArrayInt(string message, int[] array)
{
    Console.Write(message + "[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int[] InputaArrayInt(int lenght)
{
    int[] array = new int[lenght];
    for (int i=0; i < lenght; i++)
    {
        Console.Write("Введите " + (i+1) + " элемент: "  );
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
};

int ZeroSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) sum++;
    return sum;
}

Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = InputaArrayInt(m);
PrintArrayInt("Ваш массив: ", array);
Console.WriteLine("В массиве " + ZeroSum(array) + " элемента больше 0");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)

double[] ReadCoord(string message)
{
    Console.WriteLine("Введите данные прямой вида " + message);
    double[] line = new double[2];
    Console.Write("Введите k: ");
    line[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b: ");
    line[1] = Convert.ToDouble(Console.ReadLine());
    return line;
}

bool IsIntersect(double[] line1, double[] line2)
{
    return !(line1[0] == line2[0]);
}

double[] line1 = ReadCoord("y = k * y + b");
double[] line2 = ReadCoord("y = k * y + b");

if (IsIntersect(line1, line2))
{
    double x = (-line2[1] + line1[1]) / (-line1[0] + line2[0]);     // (-b2 + b1)/(-k1 + k2);
    double y = line2[0] * x + line2[1];                             // k2 * x + b2;
    Console.WriteLine("Прямые пересекутся в точке с координатами X: " + x + " Y: " + y);
}
else Console.WriteLine("Заданные прямые не пересекаются");
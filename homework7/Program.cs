// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] RndMatrixDouble(int width, int height)
{
    double[,] matrix = new double [width, height];
    for(int i = 0; i < width; i++)
        for (int j = 0; j < height; j++)
            matrix[i,j] = new Random().Next(-100, 100);
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            Console.Write("{0,-10}", matrix[i,j]);
        Console.WriteLine(matrix[i, matrix.GetLength(1) - 1] + "]");
    }
}

double[,] matrix = RndMatrixDouble(5, 10);
PrintMatrixDouble(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void CheckElementByPosition (double[,] matrix, int x, int y)
{
    if ((matrix.GetLength(0) > x) && (matrix.GetLength(1) > y) && (x >= 0) && (y >= 0)) 
        Console.WriteLine("Искомый элемент: " + matrix[x-1,y-1]);
    else
        Console.WriteLine("Такого элемента нет");
}

void CheckPositionByElement (double[,] matrix, double element)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            if (element == matrix[i,j])
            {
                Console.WriteLine("Искомый элемент располагается на позиции: строка " + (i+1) + ", столбец " + (j+1) + "]");
                return;
            }
    Console.WriteLine("Искомый элемент не обнаружен");
}

Console.Write("Элемент [2,4] -> ");
CheckElementByPosition(matrix, 2, 4);

Console.Write("Элемент 18 -> ");
CheckPositionByElement(matrix, 18);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void ColumnAverage(double[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avarage = (avarage + matrix[i, j]);
        }
        avarage = avarage / matrix.GetLength(0);
        Console.Write("{0,-10}", avarage);
    }
    Console.WriteLine();
}

ColumnAverage(matrix);

int[,] RndMatrixInt(int width, int height)
{
    int[,] matrix = new int [width, height];
    for(int i = 0; i < width; i++)
        for (int j = 0; j < height; j++)
            matrix[i,j] = new Random().Next(0, 100);
    return matrix;
}

void PrintMatrixInt(string message, int[,] matrix)
{
    Console.WriteLine(message);
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            Console.Write("{0,-4}", matrix[i,j]);
        Console.WriteLine(matrix[i, matrix.GetLength(1) - 1] + "]");
    }
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void ArraySort (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(1); k++)
                if (matrix[i, j] > matrix[i, k]) 
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
}

int[,] matrix54 = RndMatrixInt(5, 5);
PrintMatrixInt("Исходный массив: ", matrix54);
ArraySort(matrix54);
PrintMatrixInt("Отсортированный по убыванию построчно: ", matrix54);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int MatrixMinRowSumID (int[,] matrix)
{
    int min = int.MaxValue; 
    int ID = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum += matrix[i,j];
        if (sum < min) 
        {
            min = sum;
            ID = i;
        }
    }
    return ID;
}

int[,] matrix56 = RndMatrixInt(4, 6);
PrintMatrixInt("Исходный массив: ", matrix56);
Console.WriteLine("Искомый индекс строки: " + MatrixMinRowSumID(matrix56));

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

int[,] Multiplication(int[,] m1, int[,] m2)
{       
    var result = new int[m1.GetLength(0), m1.GetLength(0)];
    for (int i = 0; i < m1.GetLength(0); i++)
        for (int j = 0; j < m2.GetLength(0); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < m1.GetLength(0); k++)
                result[i, j] += m1[i, k] * m2[k, j];
        }
    return result;
}

int[,] matrix58_1 = RndMatrixInt(4, 4);
PrintMatrixInt("Матрица 1: ", matrix58_1);
int[,] matrix58_2 = RndMatrixInt(4, 4);
PrintMatrixInt("Матрица 2: ", matrix58_1);
PrintMatrixInt("Результат умножения: ", Multiplication(matrix58_1, matrix58_2));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Rnd3DInt(int dim1, int dim2, int dim3)
{
    bool IsContains(int[,,] array, int element) // Проверка наличия элемента
    {
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                for (int k = 0; k < array.GetLength(2); k++)
                    if (array[i, j, k] == element) 
                    return true;
        return false;
    }

    int[,,] matrix = new int [dim1, dim2, dim3];
    for(int i = 0; i < dim1; i++)
        for (int j = 0; j < dim2; j++)
            for (int k = 0; k < dim3; k++)
            {
                int temp = new Random().Next(0, 100);
                while(IsContains(matrix, temp))
                    temp = new Random().Next(0, 100);
                matrix[i,j,k] = temp;
            }
    return matrix;
}

void Print3DInt(string message, int[,,] matrix)
{
    Console.WriteLine(message);
    for(int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write(matrix[i,j,k] + "(" + i + "," + j + "," + k + ") ");
            Console.WriteLine();
            }
}

int[,,] array60 = Rnd3DInt(2, 2, 2);
Print3DInt("3D массив: ", array60);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] MakeSnake (int dim1, int dim2)
{
    int[,] array = new int[dim1, dim2];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
        else 
            if (i < j && i + j >= array.GetLength(0) - 1) i++;
        else 
            if (i >= j && i + j > array.GetLength(1) - 1) j--;
        else
            i--;
    }
    return array;
}
PrintMatrixInt("Спиральный массив: ", MakeSnake(4,4));
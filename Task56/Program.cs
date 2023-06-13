// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 20);
PrintMatrix(array2d);
Console.WriteLine("");
int result = FindRowWithMinimalSumOfElements(array2d) + 1;
Console.WriteLine($"номер строки с наименьшей суммой элементов: {result}");

int FindRowWithMinimalSumOfElements(int[,] matrix)
{
    int[] sumsOfRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
            sumsOfRows[i] = sum;
        }
    }
    int minIndex = 0;
    int min = sumsOfRows[0];
    for (int i = 0; i < sumsOfRows.Length; i++)
    {
        if (sumsOfRows[i] < min) minIndex = i;
    }
    return minIndex;
}

// void PrintArray(int[] arr, string sep = ",")
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write ($"{arr[i]}{sep} ");
//         else Console.Write ($"{arr[i]}");
//     }
// }

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // rows = 3, columns = 4
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}
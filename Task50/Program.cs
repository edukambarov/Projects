// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int inputRows = FromStringToInt("Введите первый индекс для поиска элемента массива: ");
int inputColumns = FromStringToInt("Введите второй индекс для поиска элемента массива: ");
int[,] array2d = CreateMatrixRndInt(5, 5, -25, 25);
PrintMatrix(array2d);
MatrixElementExists(array2d, inputRows, inputColumns);

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

void MatrixElementExists(int[,] matrix, int rows, int columns)
{
    if (rows >= 0 && columns >= 0)
    {
        if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1))
        {
            Console.Write($"Элемент c индексами [{rows},{columns}] равен {matrix[rows, columns]}.");
        }
        else Console.Write($"Элемент c индексами [{rows},{columns}] не существует.");
    }
    else Console.Write("Индекс элемента массива не может быть отрицательным. Введите неотрицательное число.");
}

int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}
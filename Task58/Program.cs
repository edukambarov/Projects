﻿// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array2dA = CreateMatrixRndInt(4, 2, 1, 10);
Console.WriteLine("Матрица А: ");
PrintMatrix(array2dA);
Console.WriteLine("");
int[,] array2dB = CreateMatrixRndInt(2, 3, 1, 10);
Console.WriteLine("Матрица B: ");
PrintMatrix(array2dB);
Console.WriteLine("");
MatrixProductExists(array2dA, array2dB);
int[,] array2dAxB = MatrixProduct(array2dA, array2dB);
PrintMatrix(array2dAxB);


void MatrixProductExists(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
        Console.WriteLine("Произведение матрицы А на матрицу В выглядит следующим образом:");
    else Console.WriteLine("Невозможно вычислить произведение матрицы А на матрицу В. Число столбцов матрицы А не совпадает с  числом строк матрицы В.");
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; // [m,n] 
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix2.GetLength(1); n++)
        {
            matrixResult[m, n] = 0;
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrixResult[m, n] = matrixResult[m, n] + matrix1[m, j] * matrix2[j, n];
            }
        }
    }
    return matrixResult;
}

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
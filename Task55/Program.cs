// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] array2d = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine("");
ReaplaceRowsColumns(array2d);
PrintMatrix(array2d);

// int[,] newarray2d = TransposeMatrix(array2d);
// PrintMatrix(newarray2d);


// int[,] TransposeMatrix(int[,] matrix)
// {
//     int maxSize = matrix.GetLength(0);
//     if (matrix.GetLength(1)> maxSize) maxSize = matrix.GetLength(1);
//     int[,] newmatrix = new int[maxSize, maxSize];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             newmatrix[j, i] = matrix[i, j];         
//         }

//     }
//     return newmatrix;
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

void ReaplaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}


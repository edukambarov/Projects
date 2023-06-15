// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int size = 4;
int[,] squareMatrix = SpiralMatrix(size, size);
PrintMatrix(squareMatrix);

int[,] SpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int mini = 0;
    int maxi = matrix.GetLength(0) - 1;
    int minj = 0;
    int maxj = matrix.GetLength(1) - 1;
    int path = 0;
    int i = 0;
    int j = 0;
    while (path <= matrix.GetLength(0) * matrix.GetLength(1) &&
           i <= maxi &&
           j <= maxj)
    {
        for (i = mini; j < maxj; j++)
        {
            path++;
            matrix[i, j] = path;

        }
        mini++;
        for (j = maxj; i < maxi; i++)
        {
            path++;
            matrix[i, j] = path;
        }
        maxj--;
        for (i = maxi; j > minj; j--)
        {
            path++;
            matrix[i, j] = path;
        }
        maxi--;
        for (j = minj; i > mini; i--)
        {
            path++;
            matrix[i, j] = path;
        }
        minj++;
    }
    path++;
    matrix[i, j] = path;
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

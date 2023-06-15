// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int rows = 2;
int columns = 2;
int depth = 2;
int[,,] array3d = CreateAndFillMatrix3D(rows, columns, depth, 10, 99);
Print3dMatrixElementWithIndex(array3d);

int[,,] CreateAndFillMatrix3D(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int a = 1;
                int b = columns;
                int c = columns * rows;
                matrix[i, j, k] = 10 + i * a + j * b + k * c;
            }
        }
    }
    return matrix;
}

void Print3dMatrixElementWithIndex(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}
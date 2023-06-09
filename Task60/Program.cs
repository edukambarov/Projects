﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

int rows = 7;
int columns = 7;
int depth = 7;
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
                matrix[i, j, k] = 10 + i + j*2 + k*3;
                if (matrix[i, j, k] > max) matrix[i, j, k] = max;                
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
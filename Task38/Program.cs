// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = 5;
double[] array = CreateArrayRndDouble(size, 0, 99);
double max = FindMaxElement(array);
double min = FindMinElement(array);
double maxMinDiff = MaxMinDiff(max,min);
PrintArrayDouble(array);
Console.Write($"=> {max} - {min} = {maxMinDiff}");

double[] CreateArrayRndDouble(int size, int min, int max, int round = 1)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
       
    return arr;
}

void PrintArrayDouble(double[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double FindMaxElement(double[] arr) 
{
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElement) maxElement = arr[i];
    }
    return maxElement;
}

double FindMinElement(double[] arr) 
{
    double minElement = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElement) minElement = arr[i];
    }
    return minElement;
}

double MaxMinDiff(double maxElement, double minElement, int round = 1) 
{
    double maxMinDiff = maxElement - minElement;
    double result = Math.Round(maxMinDiff,round);
    return result;
}
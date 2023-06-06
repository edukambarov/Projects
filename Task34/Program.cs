// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 7;
int[] array = CreateArray(size, 100, 999);
int countEvenNumbers = CountEvenNumbers(array);
PrintArray(array);
Console.Write($"-> {countEvenNumbers}");

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (length - i > 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountEvenNumbers(int[] arr) 
{
    int count = 0;
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}
    
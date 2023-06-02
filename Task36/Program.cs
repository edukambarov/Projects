// Задача 36: Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = FromStringToInt("Задайте размер массива (число элементов): ");
int minValue = FromStringToInt("Укажите минимальное значение массива: ");
int maxValue = FromStringToInt("Укажите максимальное значение массива: ");
int[] array = CreateArray(size, minValue, maxValue);
int sumIfOddIndex = SumIfOddIndex(array);
PrintArray(array);
Console.Write($"-> {sumIfOddIndex}");

int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}

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

int SumIfOddIndex (int[] arr) 
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
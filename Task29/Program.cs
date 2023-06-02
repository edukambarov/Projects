// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int length =  FromStringToInt("Введите количество элементов массива: ");
int max = FromStringToInt("Введите максимальное значение элемента: ");
int min = FromStringToInt("Введите минимальное значение элемента: ");
int[] array = CreateArray(length, min, max);
PrintArray(array);

int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
}

int[] CreateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random rnd = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rnd.Next(minValue,maxValue+1);
    }
    return array;
}

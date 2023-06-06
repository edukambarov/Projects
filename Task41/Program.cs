// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int size = FromStringToInt("Введите размер массива: ");
int[] array = Inputarray(size);
PrintArray(array);
Console.WriteLine($"{CountPositiveElements(array)} - количество введённых вами положительных чисел.");

int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}

int[] Inputarray (int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = FromStringToInt($"Введите {i + 1}й элемент массива: ");
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length-1]}]");
}

int CountPositiveElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
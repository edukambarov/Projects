// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int UserInput(string message){
//     Console.WriteLine(message);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// void PrintFibanacci(int num)
// {
// int elem1 = 0;
// int elem2 = 1;
// int temp = 0;
// Console.Write($"Если N = {num} -> {elem1} {elem2} ");
// for (int i = 2; i < num; i++)
// {
//     temp = elem2;
//     elem2 = elem1 + elem2;
//     elem1 = temp;

//     Console.Write($"{elem2} ");
// }
// }

// int number = UserInput("Введите натуральное число: ");
// PrintFibanacci(number);

int[] CreateArrayFibonacci(int size, int first, int second)
{
    int[] array = new int[size];
    array[0] = first;
    array[1] = second;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
 
 void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int[] array = CreateArrayFibonacci(6, 7, 11);
PrintArray(array);
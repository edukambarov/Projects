// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка [100, 999] -> {number}");

if (num < 1)
{
        Console.WriteLine("Некорректный ввод.");
}
else
{
    int i = 2;
    while (i <= num)
    {
        Console.Write($"{i} ");
        i=i+2;
    }
}

if (num < 1)
{
        Console.WriteLine("Некорректный ввод.");
}
else
{
    int i = 2;
    while (i <= num)
    {
        Console.Write($"{i} ");
        i=i+2;
    }
}
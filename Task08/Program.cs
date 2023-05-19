//  Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

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
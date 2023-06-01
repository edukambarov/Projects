// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = FromStringToInt("Введите целое число: ");
int sumOfDigits = SumOfDigits(number);
Console.WriteLine($"Cумма цифр заданного числа {number} составляет {sumOfDigits}.");

int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}

int SumOfDigits(int num)
{
    int sum = 0;
    for (int i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num = num / 10;       
    }
    return sum;
}
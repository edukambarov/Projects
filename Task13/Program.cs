// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number  = FromStringToInt("Введите число: ");
if (ComparisonWithArgument(number))
{
    Console.WriteLine(ThirdDigit(number));
}

int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}

int ThirdDigit (int number)
{
    while (number > 999)
    {
        number  = number / 10;
    }
    return number % 10;
}

bool ComparisonWithArgument(int number)
{
    if (number < 100) 
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
    


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int number  = FromStringToInt("Введите порядковый номер дня недели: ");
if (WeekendOrNot(number))
{
    Console.WriteLine("Некорректный ввод");
}

int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}

bool WeekendOrNot(int number)
{
    if (number > 5 && number < 8) 
    {
        Console.WriteLine($"Да, {number}й день недели выходной:-)");
        return false;
    }
    else if (number > 0 && number < 6)
       {
        Console.WriteLine($"Нет, {number}й день недели не выходной:-(");
        return false;
       }
       return true;
}
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



    int number = FromStringToInt("Введите число: ");
    int reverse = Reverse(number);
    if (number==reverse)
    {
        Console.WriteLine($"Заданное число {number} является полиндромом.");
    }
    else
    {
        Console.WriteLine($"Заданное число {number} не является полиндромом.");
    }         
    
int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}

int Reverse(int number)
{
    int reminder = 0;
    int reverse = 0;

while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            return reverse;
}

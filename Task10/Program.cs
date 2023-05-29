// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}

int FindSecondDigit(int num)
{
     int twofirstDigits = Math.Abs(num / 10);  
     int result2 = twofirstDigits % 10;
     return result2;
}
int number = FromStringToInt("Введите целое трёхзначное число: ");

if (Math.Abs(number) < 100 ||  Math.Abs(number) > 999)
{ 
 Console.WriteLine("Введены некорректные данные");
 return;
}
 int secondDigit = FindSecondDigit(number);
 Console.WriteLine($"Второй цифрой заданного числа {number} является цифра {secondDigit}.");



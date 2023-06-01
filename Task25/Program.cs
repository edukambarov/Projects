// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number = FromStringToInt("Введите целое число (основание): ");
int degree = FromStringToInt("Введите натуральное число (степень): ");
int exp = DoExponentiation(number,degree);
int parameter = 0;
if (ComparisonWithParameter(degree, parameter))
{
    Console.WriteLine($"Число {number} в степени {degree} равно {exp}.");
}

int FromStringToInt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result1 = Convert.ToInt32(value);
    return result1;
}

bool ComparisonWithParameter (int number, int parameter)
{
    if (number < parameter)
    {
    Console.WriteLine("Введено некорректное число");
    return false;
    }
    return true;
}

int DoExponentiation (int number, int degree) 
{
        int temp = number;
        for (int i = 1; i < degree; i++)
    {
        checked
        {
           number = number*temp;           
        }
    }
    return number;
}
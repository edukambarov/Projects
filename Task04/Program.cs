// Напишите программу, которая принимает на 
// вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine ("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье целое число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2>max)
{
    max=num2;
}
     if (num3>max)
     {
        max=num3;
     }
Console.WriteLine ($"{max} является наибольшим из заданных чисел.");
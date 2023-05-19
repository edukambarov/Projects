// Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а 
// какое меньшее
Console.WriteLine ("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max)
{
    Console.WriteLine ($"{num2} является наибольшим из заданных чисел.");
}
else 
{
    Console.WriteLine ($"{num1} является наибольшим из заданных чисел.");
}
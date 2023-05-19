// Напишите программу, которая на вход 
// принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
Console.WriteLine ("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int rem = num % 2;
if (rem==0)
{
    Console.WriteLine($"Число {num} является чётным");
}
else
{
    Console.WriteLine($"Число {num} не является чётным");
}

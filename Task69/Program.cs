﻿// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowerRec(int num, int pow)
{
    if (pow == 0) return 1;
    else return num * PowerRec(num, pow - 1);
}

Console.WriteLine("Введите два натуральных числа: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowerRec(baseNumber, power));int PowerRec(int num, int pow)
{
    if (pow == 0) return 1;
    return num * PowerRec(num, pow - 1);
}

Console.WriteLine("Введите два натуральных числа: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PowerRec(baseNumber, power));
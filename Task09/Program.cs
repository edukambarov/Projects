﻿// 9. Напишите программу, которая A 
// выводит
// случайное число из отрезка [10, 99] и C показывает
// D наибольшую цифру числа.            
// 78 -> 8
// 12-> 2
// 85 -> 89. 

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число тз отрезка 10 - 99 -> {num}");

int firstDigit = num / 10;     
int secondDigit = num % 10;
if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
}
else 
    Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");
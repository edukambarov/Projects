﻿// Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу, которая
//  выведет все натуральные числа в промежутке от N до 1. 
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Данная промежуточная аттестация оценивается по системе "зачет" / "не зачет".
// Данная промежуточная аттестация оценивается по системе "зачет" / "не зачет".
// "Зачет"" ставится, если Слушатель успешно выполнил 3 или 2 критерия.
// "Незачет"" ставится, если Слушатель успешно выполнил 1 или меньше критериев.

// Критерии оценивания:
// 1 - Слушатель написал корректную программу с использованием рекурсии 
// по выведению всех натуральных чисел в промежутке от N до 1.
// 2 - Слушатель написал корректную программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.
// 3 - Слушатель написал корректную программу
//  с использованием рекурсии по вычислению функции Аккермана

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
NaturalNumbersBackWards(number);

void NaturalNumbersBackWards (int num) // num = 5
{
    if (num == 0) return;
    NaturalNumbersBackWards (num-1);
    Console.Write($"{temp-num+1} ");    
}
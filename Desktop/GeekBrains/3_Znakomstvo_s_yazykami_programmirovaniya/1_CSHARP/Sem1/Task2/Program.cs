﻿// Задача 2
// Напишите программу, которая на вход принимает 
// целое число N, а на выходе показывает все целые 
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = num * -1;
while (count <= num)
{
    if (count < num)
    {
        Console.Write($"{count}, ");
    }
    if (count == num)
    {
        Console.Write($"{count}");
    }
    count++;
}


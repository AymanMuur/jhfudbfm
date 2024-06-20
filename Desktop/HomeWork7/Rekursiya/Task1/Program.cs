// Задача 1: Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.
// Пример.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void PrintNumbersInRange(int numM, int numN)
{
    Console.Write(numM);
    if (numM < numN)
    {
        Console.Write(", ");
        PrintNumbersInRange(numM + 1, numN);
    }
}

System.Console.WriteLine("Введите значение М: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbersInRange(m, n);
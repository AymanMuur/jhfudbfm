// Задача 3: Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа

Console.Write("Введите число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int num1 = num % 10;
    int num2 = num / 10;
    if (num1 > num2)
    {
        Console.WriteLine(num1);
    }
    else
    {
        Console.WriteLine(num2);
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}
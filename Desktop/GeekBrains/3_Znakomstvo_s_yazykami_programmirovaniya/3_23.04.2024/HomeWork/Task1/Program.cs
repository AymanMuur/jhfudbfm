// Задача 1: Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23

Console.Write("Введите целое число: ");
int num = Convert.ToInt16(Console.ReadLine());

int dif1 = num % 7;
int dif2 = num % 23;

if (dif1 == 0 && dif2 == 0)
{
    Console.Write("Да!");
}
else
{
    Console.Write("Нет!");
}




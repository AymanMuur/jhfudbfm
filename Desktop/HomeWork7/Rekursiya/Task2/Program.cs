// Задача 2: Напишите программу вычисления
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Пример:
// m = 2, n = 3 -> A(m,n) = 29

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}


System.Console.WriteLine("Введите целое положительное число М: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction(m, n);
Console.WriteLine("A({0}, {1}) = {2}", m, n, result);



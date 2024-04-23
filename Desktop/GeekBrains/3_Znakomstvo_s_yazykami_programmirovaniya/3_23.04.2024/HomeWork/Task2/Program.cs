// Задача 2: Напишите программу, которая принимает 
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
// 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка


Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && Y > 0)
{
    Console.WriteLine("Номер координатной четверти плоскости: 1");
}
else if (x < 0 && Y > 0)
{
    Console.WriteLine("Номер координатной четверти плоскости: 2");
}
else if (x < 0 && Y < 0)
{
    Console.WriteLine("Номер координатной четверти плоскости: 3");
}
else if (x > 0 && Y < 0)
{
    Console.WriteLine("Номер координатной четверти плоскости: 4");
}
else
{
    Console.WriteLine("Ошибка ввода!");
}

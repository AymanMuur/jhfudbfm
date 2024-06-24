// Задача 4.
// Дано: 5 гирь с разным весом в случайном порядке.
// Найти: вес самой тяжёлой гири.

int a = 95;
int b = 66;
int c = 2;
int d = 800;
int e = 34;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}

Console.WriteLine(max);


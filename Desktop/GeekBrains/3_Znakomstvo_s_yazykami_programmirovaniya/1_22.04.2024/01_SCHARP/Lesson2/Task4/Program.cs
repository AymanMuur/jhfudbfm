// Задача №3
// Дано 10 гирь с разным весом в случайном 
// порядке. Определить вес самой тяжелой 
// гири.


int[] arr = { 5, 34, 78, 94, 67 };
int i = 0;
int max = arr[0];

while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i++;
}
Console.WriteLine(max);
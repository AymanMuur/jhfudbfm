// Задача 3: Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы. 
// Пример:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1


void PrintArrayReversed(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write(arr[index] + " ");
        PrintArrayReversed(arr, index - 1);
    }
    
}
int[] arr = { 1, 2, 5, 0, 10, 34 };
Console.Write("[ ");
PrintArrayReversed(arr, arr.Length - 1);
Console.Write("]");
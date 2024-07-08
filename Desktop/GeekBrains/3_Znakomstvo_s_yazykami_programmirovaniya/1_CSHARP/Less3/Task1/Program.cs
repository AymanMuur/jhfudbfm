// Вычислить значение формулы: a*b/c+d, 
// где  a,b,c,d - некоторые целые числа.
// Решение оформить в виде функции. 

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;

    double result = numenator / denumenator;
    return result;
}

double res = CalculateFormula(9, 1, 3, 5);
Console.WriteLine(res);
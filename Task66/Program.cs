// Задача 66. Задайте значения от M до N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N
int SumOfRange(int m, int n)
{
    if (m == n)
        return n;
    return m + SumOfRange(m + 1, n);
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма элементов от M до N включительно: {SumOfRange(m, n)}");
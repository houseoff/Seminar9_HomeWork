// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.
int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermanFunction(m - 1, 1);
    return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат вычисления функции Аккермана: {AckermanFunction(m, n)}");
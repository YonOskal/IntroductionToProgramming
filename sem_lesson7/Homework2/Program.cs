// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int FunctionAccerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return FunctionAccerman(n - 1, 1);
    }
    return FunctionAccerman(n - 1, FunctionAccerman(n, m - 1));
}

Console.WriteLine("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = FunctionAccerman(n, m);
Console.WriteLine($"Результат функции Аккермана для n = {n} и m = {m} равен {res}");
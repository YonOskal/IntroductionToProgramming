// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
static bool IsPalindrome(string inp)
{
    for (int i = 0; i < inp.Length / 2; i++)
    {
        if (inp[i] != inp[inp.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}

Console.WriteLine("Напишите строку: ");
string input = Console.ReadLine();

if (IsPalindrome(input))
{
    Console.WriteLine($"Слово \"{input}\" является палиндромом.");
}
else
{
    Console.WriteLine($"Слово \"{input}\" не является палиндромом.");
}
    
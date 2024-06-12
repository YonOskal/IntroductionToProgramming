// Считать строку с консоли, содержащую латинские
// буквы. Вывести на экран согласные буквы этой
// строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d

using System;

static void CheckConsonants(string inp, int index)
{
    string vowels = "aoeiuy";
    if (char.IsAsciiLetter(inp[index]) && !vowels.Contains(Char.ToLower(inp[index])))
    {
        Console.Write($"{inp[index]}");
    }
}



void PrintConsonants(string inp, int index = 0)
{
    if (index == inp.Length)
    {
        return;
    }
    CheckConsonants(inp, index);
    PrintConsonants(inp, index + 1);
}


Console.WriteLine("Введите строку: ");
string input = Console.ReadLine();
Console.WriteLine();
PrintConsonants (input);
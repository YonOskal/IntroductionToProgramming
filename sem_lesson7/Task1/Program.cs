// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

void PrintNaturalNumbers(int number)
{
    if (number == 0) return;
    PrintNaturalNumbers(number - 1);
    Console.Write($"{number} ");
}

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(num);



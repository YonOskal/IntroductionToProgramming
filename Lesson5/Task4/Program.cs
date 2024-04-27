// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (max < min)
// {
//     int max = num2;
//     int min = num1;
// }
// else if (max == num2);
// {
//     Console.WriteLine("Числа равны");
// }
// int min = num2
// Console.WriteLine($"Максимальное число = {max}");
// Console.WriteLine($"Минимальное число = {min}");
// /////////////////
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
int min = num2;

if (max < num2)
{
    max = num2;
    min = num1;
}
else if (max == num2)
{
    Console.WriteLine("Числа равны");
    // Возможно, здесь нужно что-то еще сделать в случае равенства чисел
}
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Минимальное число = {min}");

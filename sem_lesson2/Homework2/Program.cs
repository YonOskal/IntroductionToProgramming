// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
// координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите число X: ");
int X = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Первая четверть координат");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Вторая четверть координат");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья четверть координат");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Четвертая четверть координат");
}
else
{
    Console.WriteLine("Некоректный ввод координат");
}
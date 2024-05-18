// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа

Console.WriteLine("Введите двухзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = 0;
int num2 = 0;

if (num >= 10 && num <= 99)
{
    num1 = num / 10;
    num2 = num % 10;
    
    if (num1 > num2)
{
    Console.WriteLine("Наибольшее число " + num1);
}
    else if (num2 > num1)
{
    Console.WriteLine("Наибольшее число " + num2);
}
 else
{
    Console.WriteLine("Числа равны");
}
}
else
{
    Console.WriteLine("Некоректный ввод");
}
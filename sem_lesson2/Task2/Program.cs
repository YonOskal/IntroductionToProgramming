Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SecondDigit = 0;
int ThirdDigit = 0;
if (num >= 100 && num <= 999)
{
    SecondDigit = num / 10 % 10;
    ThirdDigit = num % 10;
}
else
{
    Console.WriteLine("Некоректный ввод");
}
int result = SecondDigit;
int count = 1;
while (count < ThirdDigit)
{
    result *= SecondDigit; //result = result * SecondDigit
    count++;
}
 Console.WriteLine(result);
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3-х значное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (ThreeDigit(number))
{
    int result = DigitSecond(number);
    Console.WriteLine($"{number} -> {result}");
}
else
{
    Console.WriteLine("Число не 3-х значное");
}

int DigitSecond(int num)
{
    int digitSecond = (num / 10) % 10;
    return digitSecond;
}

bool ThreeDigit(int num)
{
    return (num > 99 && num < 1000) || (num < -99 && num > -1000);
}
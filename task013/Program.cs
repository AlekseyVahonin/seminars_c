// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите 3-х значное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (MoreThreeDigit(number))
{
    int result = ThreeDigit(number);
    Console.WriteLine($"{number} -> {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

bool MoreThreeDigit(int num)
{
    return num > 99 || num < -99;
}

int ThreeDigit(int num)
{
    while (num > 999 || num < 0 && num < -999)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}
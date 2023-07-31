//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//12 -> 2

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountNumberDigit(number);
Console.WriteLine($"Количество цифр в числе {number} = {result}");

int CountNumberDigit(int num)
{
    int countDigit = 0;
    while (num != 0)
    {
        countDigit++;
        num = num / 10;
    }
    return countDigit;
}
// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * -1;
}

int result = number % 10;

if (number > 99)
{
    Console.WriteLine($"Последняя цифра числа {number} равна: {result}");
}
else
{
    Console.WriteLine("Это число не трёхзначное");
}
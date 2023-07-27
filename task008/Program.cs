// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN < 0)
{
    Console.Write("Введите натуральное число (N): ");
}
else
{   Console.Write($"{numberN} ->");
    int i = 1;
    while (i <= numberN)
    {
        if (i % 2 == 0)
        {
            Console.Write($" {i}");
        }
        i++;
    }
}
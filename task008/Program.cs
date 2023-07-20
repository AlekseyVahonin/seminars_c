// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.Write($"{numberN} ->");

int flag = 0;
if (numberN < 0)
{
    numberN *= -1;
    flag = 1;
}

int i = 1;
while (i <= numberN)
{
    if (i % 2 == 0)
    {
        if (flag == 1)
        {
            if (numberN - i == 0 | numberN - i == 1)
            {
                Console.WriteLine($" {-i}");
            }
            else
            {
                Console.Write($" {-i},");
            }
        }
        else
        {
            if (numberN - i == 0 | numberN - i == 1)
            {
                Console.WriteLine($" {i}");
            }
            else
            {
                Console.Write($" {i},");
            }
        }
    }
    i++;
}
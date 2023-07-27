// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите N(натуральное число)");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.Write($"{number} -> ");
    TableOfCubes(number);
}
else
{
    Console.WriteLine("Вы ввели не натуральное число N(1,2,3,4...)");
}

void TableOfCubes(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int result = i * i * i;
        if (num - i > 0)
        {
            Console.Write($"{result}, ");
        }
        else
        {
            Console.WriteLine($"{result}");
        }
    }
}
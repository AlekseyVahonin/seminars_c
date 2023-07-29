// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 ->
// 1 | 1
// 2 | 8
// 3 | 27


Console.WriteLine("Введите N(натуральное число)");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) TableOfCubes(number);
else Console.WriteLine("Вы ввели не натуральное число N(1,2,3,4...)");

void TableOfCubes(int num)
{
    Console.WriteLine($"{num} ->");
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i, 3} | {Math.Pow(i, 3), -10}");
    }
}
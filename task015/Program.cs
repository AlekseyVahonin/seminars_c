// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    bool result = Weekend(number);
    Console.WriteLine(result ? $"{number} -> да" : $"{number} -> нет");
}
else
{
    Console.WriteLine("Число не от 1 до 7");
}

bool Weekend(int num)
{
    return num == 6 || num == 7;
}

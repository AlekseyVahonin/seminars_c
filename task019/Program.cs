// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (FiveDigit(number))
{
    Console.WriteLine(Polydrome(number) ? "полиндром" : "не полиндром");
}
else
{
    Console.WriteLine("Число не питизнаяное");
}

bool FiveDigit(int num)
{
    return num / 10000 > 0;
}

bool Polydrome(int numberDigit)
{
    return numberDigit / 10000 == numberDigit % 10 && numberDigit / 1000 % 10 == numberDigit / 10 % 10;
}
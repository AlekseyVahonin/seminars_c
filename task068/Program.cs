// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AckermannFunction(int numberM, int numberN)
{
    while (numberM != 0)
    {
        if (numberN == 0) numberN = 1;
        else numberN = AckermannFunction(numberM, numberN - 1);
        --numberM;
    }
    return ++numberN;
}

Console.Write("Введите целое положительное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое положительное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 && numberN < 0)
{
    Console.WriteLine("Введите целые положительные числа");
    return;
}

int result = AckermannFunction(numberM, numberN);
Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {result}");
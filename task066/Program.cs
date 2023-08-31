// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumNaturalNumbers(int numM, int numN)
{
    if (numM <= 0) numM = 1;
    if (numN <= 0) numN = 1;

    if (numM < numN) return numM + SumNaturalNumbers(numM + 1, numN);
    else if (numM > numN) return numN + SumNaturalNumbers(numM, numN + 1);
    else return numM;

}

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 && numberN < 1)
{
    Console.WriteLine($"Натуральных элементов в промежутке от {numberM} до {numberN} не существует");
    return;
}

int result = SumNaturalNumbers(numberM, numberN);
Console.Write($"M = {numberM}; N = {numberN} -> ");
Console.WriteLine(result);
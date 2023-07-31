// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа A");
int numberB = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"{numberA}, {numberB} -> {DegreeNumber(numberA, numberB)}");

int DegreeNumber(int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        checked
        {
            result = result * numA;
        }
    }
    return result;
}
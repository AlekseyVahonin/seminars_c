// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        //arr[i] = rnd.Next(min, max) + rnd.NextDouble();
    }

    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 2)}, ");
        else Console.Write($"{Math.Round(arr[i], 2)}");
    }
    Console.Write("]");
}

double MinNumberArray(double[] arr)
{
    double minNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (minNumber > arr[i]) minNumber = arr[i];
    }
    return minNumber;
}

double MaxNumberArray(double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (maxNumber < arr[i]) maxNumber = arr[i];
    }
    return maxNumber;
}

double DifferenceMinMax(double minNum, double maxNum)
{
    double result = maxNum - minNum;
    return result;
}

double[] array = CreateArrayRndDouble(5, 1, 100);

double minNumberArray = MinNumberArray(array);
double maxNumberArray = MaxNumberArray(array);

double differenceMinMax = DifferenceMinMax(minNumberArray, maxNumberArray);

PrintArray(array);
Console.WriteLine($" => {Math.Round(maxNumberArray, 2)} - {Math.Round(minNumberArray, 2)} = {Math.Round(differenceMinMax, 2)}");
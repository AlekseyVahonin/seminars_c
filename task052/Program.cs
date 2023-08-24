// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMeanColumnsMatrix(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    double temp;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp += matrix[i, j];
        }
        arr[j] = temp / matrix.GetLength(0);
    }

    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 1)}; ");
        else Console.Write($"{Math.Round(arr[i], 1)}.");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2d);

double[] arrResult = ArithmeticMeanColumnsMatrix(array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(arrResult);
Console.WriteLine();
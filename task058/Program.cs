// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

bool ValidateCompatibilityMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    return matrixOne.GetLength(1) == matrixTwo.GetLength(0);
}

int[,] ProductTwoMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                matrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }

    return matrix;
}

Console.WriteLine("Даны 2 матрицы:");

int[,] matrixA = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(matrixA);

Console.WriteLine("     X");

int[,] matrixB = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(matrixB);

if (ValidateCompatibilityMatrix(matrixA, matrixB))
{
    int[,] productMatrixAB = ProductTwoMatrix(matrixA, matrixB);
    Console.WriteLine("Результирующая матрица будет:");
    PrintMatrix(productMatrixAB);
}
else Console.WriteLine("Матрицы не совместимы");
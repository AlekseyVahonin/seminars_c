// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

bool ValidateElemMatrix(int valRow, int valColumn, int[,] valMatrix)
{
    return valRow > valMatrix.GetLength(0) - 1 || valColumn > valMatrix.GetLength(1) - 1 || valRow < 0 || valColumn < 0;
}

Console.Write("Введите номер строки от 0: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца от 0: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 500);
PrintMatrix(array2d);

bool result = ValidateElemMatrix(row, column, array2d);
Console.Write($"{row}, {column} -> ");
Console.WriteLine(result ? "такого элемента в массиве нет" : $"{array2d[row, column]}");
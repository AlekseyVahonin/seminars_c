// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void CreateSpiralMatrix(int[,] matrix,
                        int endRow,
                        int endColumn,
                        int startRow = 0,
                        int startColumn = 0,
                        int num = 1)
{
    if (startRow <= endColumn && startColumn <= endRow)
    {
        int flag = 0;

        //top
        if (flag == 0)
        {
            for (int i = startRow; i <= endColumn; i++)
            {
                matrix[startRow, i] = num++;
                flag = 1;
            }
        }

        //right
        if (flag == 1)
        {
            flag = 0;
            for (int i = startRow + 1; i <= endRow; i++)
            {
                matrix[i, endColumn] = num++;
                flag = 1;
            }
        }

        //bottom
        if (flag == 1)
        {
            flag = 0;
            for (int i = endColumn - 1; i >= startColumn; i--)
            {
                matrix[endRow, i] = num++;
                flag = 1;
            }
        }

        //left
        if (flag == 1)
        {
            flag = 0;
            for (int i = endRow - 1; i >= startRow + 1; i--)
            {
                matrix[i, startColumn] = num++;
                flag = 1;
            }
        }
        CreateSpiralMatrix(matrix,
                            endRow - 1,
                            endColumn - 1,
                            startRow + 1,
                            startColumn + 1,
                            num);
    }

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

int[,] array2d = new int[4, 4];
CreateSpiralMatrix(array2d, array2d.GetLength(0) - 1, array2d.GetLength(1) - 1);
PrintMatrix(array2d);
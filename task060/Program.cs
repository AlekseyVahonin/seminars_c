// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)


int[] CreateArray(int min, int max)
{
    int[] array = new int[max + 1 - min];
    int index = 0;

    for (int i = min; i < max + 1; i++)
    {
        array[index] = i;
        index++;
    }

    return array;
}

void ShuffleElemArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        int rndIndex = rnd.Next(0, arr.Length);
        int temp = arr[i];
        arr[i] = arr[rndIndex];
        arr[rndIndex] = temp;
    }
}

int[,,] Array3dUniqueRandom(int[] arr, int row, int column, int depth)
{
    int[,,] array3d = new int[row, column, depth];
    Random rnd = new Random();
    int index = rnd.Next(0, arr.Length - row * column * depth - 1);

    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = arr[++index];
            }
        }
    }

    return array3d;
}

void PrintArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k]}({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }
}

int[] arrayTwoDigitNum = CreateArray(10, 99);
ShuffleElemArray(arrayTwoDigitNum);

int[,,] arr3d = Array3dUniqueRandom(arrayTwoDigitNum, 2, 2, 2);
PrintArray3d(arr3d);
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] CreateArrayInt(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountPositiveNumbersArray(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }

    return count;
}

Console.WriteLine("Введите количество чисел");
int countNambers = Convert.ToInt32(Console.ReadLine());

int[] result = CreateArrayInt(countNambers);
PrintArray(result);
Console.WriteLine();

int countPositiveNumbersArray = CountPositiveNumbersArray(result);
Console.WriteLine($"Количество чисел больше 0 равно {countPositiveNumbersArray}");
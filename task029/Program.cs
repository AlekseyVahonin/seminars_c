// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];

FillArr(array);
PrintArr(array);
Console.Write("-> ");
Console.Write("[ ");
PrintArr(array);
Console.Write("]");
Console.WriteLine();

void FillArr(int[] arr)
{
    Random rnd = new Random(); // создаем экземпляр класса Random
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(9); // Вызываем публичный метод Next() класса Random
    }
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
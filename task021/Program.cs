// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату точки A по оси X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки A по оси Y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки A по оси Z");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси X");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси Y");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси Z");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance3d = Distance3d(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {Math.Round(distance3d, 2)}");

double Distance3d(int numX1, int numY1, int numZ1, int numX2, int numY2, int numZ2)
{
    double result = Math.Sqrt(Math.Pow((numX2 - numX1), 2) + Math.Pow((numY2 - numY1), 2) + Math.Pow((numZ2 - numZ1), 2));
    return result;
}
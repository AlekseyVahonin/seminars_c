// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double LinesX(double b1LinesX, double k1LinesX, double b2LinesX, double k2LinesX)
{
    double x = (b2LinesX - b1LinesX) / (k1LinesX - k2LinesX);
    return x;
}

double LinesY(double b1LinesY, double k1LinesY, double LinesX)
{
    double y = k1LinesY * LinesX + b1LinesY;
    return y;
}

bool LinesCollinear(double b1Collinear, double k1Collinear, double b2Collinear, double k2Collinear)
{
    return b1Collinear * k2Collinear - b2Collinear * k1Collinear == 0;
}


Console.WriteLine("Введите переменную b1");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите переменную k1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите переменную b2");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите переменную k2");
double k2 = Convert.ToDouble(Console.ReadLine());

if (LinesCollinear(b1, k1, b2, k2))
{
    Console.WriteLine("Прямые парралельны или совпадают");
}
else
{
    double linesX = LinesX(b1, k1, b2, k2);
    double linesY = LinesY(b1, k1, linesX);

    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({linesX}; {linesY})");
    Console.WriteLine();
}

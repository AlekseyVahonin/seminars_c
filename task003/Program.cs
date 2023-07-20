// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("Введите номер дня недели: ");
int numberA = Convert.ToInt32(Console.ReadLine());

string[] daysOfWeek = { "Понедельник", "Вторник", "Среда",
      "Четверг", "Пятница", "Суббота", "Воскресенье" };
int size = 7;
int i = 0;
if (numberA > 0 & numberA <= 7)
{
    while (i >= size)
    {
        if (numberA == i + 1)
        {
            Console.WriteLine(daysOfWeek[i]);
        }
    }
    i++;
}
else
{
    Console.WriteLine("Введите целое число от 1 до 7");
}
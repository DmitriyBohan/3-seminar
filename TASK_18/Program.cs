/*
Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.WriteLine("Введите размер вашей плоскости в точках");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер четверти (от 1 до 4) чтобы узнать диапозон возможных точек");
int NumberQuater = Convert.ToInt32(Console.ReadLine());

if ( NumberQuater == 1 || NumberQuater == 2)
{
    Console.WriteLine($"Диапозон возможных точек координат по Х: от 0 до {Number}");
}
else if (NumberQuater == 3 || NumberQuater == 4)
{
    Console.WriteLine($"Диапозон возможных точек координат по Х: от 0 до {-Number}");
}
if (NumberQuater == 1 || NumberQuater == 4)
{
    Console.WriteLine($"Диапозон возможных точек координат по Y: от 0 до {Number}");
}
else if (NumberQuater == 2 || NumberQuater == 3)
{
    Console.WriteLine($"Диапозон возможных точек координат по Y: от 0 до {-Number}");
}

/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. 
*/

Console.WriteLine("укажите координаты и мы скажем в какой четверти плоскости находится эта точка");
Console.WriteLine("укажите координаты X: ");
int Xcord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("укажите координаты Y: ");
int Ycord = Convert.ToInt32(Console.ReadLine());
if (Xcord > 0)
{
    if (Ycord > 0)
    {
        Console.WriteLine("Ваша точка находится в 1-ой плоскости координат");
    }
    else
    {
        Console.WriteLine("Ваша точка находится во 2-ой плоскости координат");
    }
}
else if (Xcord < 0)
{
    if (Ycord < 0)
    {
        Console.WriteLine("Ваша точка находится в 3-ей плоскости координат");
    }
    else
    {
        Console.WriteLine("Ваша точка находится в 4-ой плоскости координат");

    }
}
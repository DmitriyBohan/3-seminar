/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. 
*/

int GetNumberOfQuater(int x, int y)
{
    int result = 0;
if (x > 0 && y > 0)
{
    result = 1;
}
else if (x > 0 && y < 0)
{
    result = 2;
}
else if (x < 0 && y < 0)
{
    result = 3;
}
else if (x < 0 && y > 0)
{
    result = 4;
}
return result;
}
Console.WriteLine("Введите X :");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y :");
int userY = Convert.ToInt32(Console.ReadLine());

int quater = GetNumberOfQuater(userX,userY);
if (quater>0)
{
    Console.WriteLine($"Точка [{userX}:{userY}] находится в {quater} четверти");
}
else 
{
    Console.WriteLine($"Точка {userX}:{userY} находится в пересечении четверти");
 
}

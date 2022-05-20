/*
 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты точки А: ");
Console.WriteLine("Введите координату Х точки А: ");
int XpoitA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
int YpoitA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.WriteLine("Введите координату Х точки B: ");
int XpoitB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х точки B: ");
int YpoitB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((XpoitA-XpoitB)*(XpoitA-XpoitB)+(YpoitA-YpoitB)*(YpoitA-YpoitB));
Console.WriteLine("Расстояние между точками А и B равняется: "+ Math.Round(result,2));
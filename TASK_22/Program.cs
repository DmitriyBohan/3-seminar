/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("Напишите число, чтобы увидеть его квадраты чисел от 1 до вашего числа");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int count = 1;
int End= (number) * (number);
Console.Write($"{number} -> ");
do
{
    count = i * i;
    i++;
    Console.Write($"{count}, ");
}
while (i < number);
Console.Write(End);

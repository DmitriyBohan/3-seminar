/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
Console.WriteLine("Напишите ЛЮБОЕ значное число ,чтобы узнать является ли оно полиндромом");
int number = Convert.ToInt32(Console.ReadLine());
int revers =0;
int variable =number;
while (variable > 0)
{
    int digit = variable % 10;
    revers = revers * 10 + digit;
    variable = variable / 10;
}
if (number==revers)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}
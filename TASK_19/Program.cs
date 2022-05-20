/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
Console.WriteLine("Напишите 5-и значное число ,чтобы узнать является ли оно полиндромом");
int number = Convert.ToInt32(Console.ReadLine());
int number5 = number % 10;
int number4 = number / 10 % 10;
int number2 = number / 1000 % 10;
int number1 = number / 10000;
if (number1 == number5 && number2 == number4)
{
    Console.WriteLine($"{number} -> ДА");
}
else
{
    Console.WriteLine($"{number} -> НЕТ");
}


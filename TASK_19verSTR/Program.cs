/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
Console.WriteLine("Напишите 5-и значное число ,чтобы узнать является ли оно полиндромом");
int number = Convert.ToInt32(Console.ReadLine());
if (number.ToString().ToCharArray()[0] == number.ToString().ToCharArray()[4] && number.ToString().ToCharArray()[1] ==  number.ToString().ToCharArray()[3])
{
     Console.WriteLine($"{number} -> ДА");
}
else
{
    Console.WriteLine($"{number} -> НЕТ");
}

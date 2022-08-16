/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите число N: ");
int nNumber = Convert.ToInt32(Console.ReadLine());

int isPal = nNumber;
int r = 0;

if (nNumber > 2)
{
    while (nNumber > 0)
    {
       int k = nNumber % 10;
    r = r * 10 + k;
    nNumber = nNumber / 10;
    }
    if (isPal == r)
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }
}
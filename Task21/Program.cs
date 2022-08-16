/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты точки A: ");
int dotAx = Convert.ToInt32(Console.ReadLine());
int dotAy = Convert.ToInt32(Console.ReadLine());
int dotAz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
int dotBx = Convert.ToInt32(Console.ReadLine());
int dotBy = Convert.ToInt32(Console.ReadLine());
int dotBz = Convert.ToInt32(Console.ReadLine());

double dotC = Math.Sqrt(Math.Pow((dotAx) - (dotBx), 2) + Math.Pow((dotAy) - (dotBy), 2) + Math.Pow((dotAz) - (dotBz), 2));
Console.WriteLine(Math.Round(dotC, 2));


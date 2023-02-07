// Задача №17. 
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.WriteLine("Введите координату X:");
int X = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int Y = int.Parse(Console.ReadLine());

if (X>0 && Y>0)
{
    Console.WriteLine("I");
}
if (X<0 && Y>0)
{
    Console.WriteLine("II");
}
if (X<0 && Y<0)
{
    Console.WriteLine("III");
}
if (X>0 && Y<0)
{
    Console.WriteLine("IV");
}
else
{
    Console.WriteLine("В одной из координат задано число ноль, что не соответветсвует условию задачи.");
}
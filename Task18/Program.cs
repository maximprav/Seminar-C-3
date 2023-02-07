// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер необходимой четверти оси координат:");
int number = int.Parse(Console.ReadLine());
if (number ==1)
{
    Console.WriteLine("В первой четверти оси координат X>0 Y>0");
}
if (number ==2)
{
    Console.WriteLine("Во второй четверти оси координат X<0 Y>0");
}
if (number ==3)
{
    Console.WriteLine("В третьей четверти оси координат X<0 Y<0");
}
if (number ==4)
{
    Console.WriteLine("В четвертой четверти оси координат X>0 Y<0");
}
else
{
    Console.WriteLine("Задано неверное значение четверти оси координат!");
}
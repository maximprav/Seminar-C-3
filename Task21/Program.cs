// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.WriteLine("Введите координату X первой точки:");
int xA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки:");
int yA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки:");
int xB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки:");
int yB = int.Parse(Console.ReadLine());
double number = Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA));

Console.WriteLine($"Длина отрезка между заданными точками равна {number}");
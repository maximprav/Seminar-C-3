// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.WriteLine("Введите любое положительное число:");
int N = int.Parse(Console.ReadLine());
int count = 1;

if (N<1)
{
    Console.WriteLine("Задано неверное число.");
}
else
{
    while (count < N)
    {
        Console.Write ($"{count*count}, ");
        count++;
    }
Console.Write($"{N*N}.");
}
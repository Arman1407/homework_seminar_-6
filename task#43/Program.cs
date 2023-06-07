// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.Write("Введите значение b1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
int c = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
int c = int.Parse(Console.ReadLine()!);

if (a < b + c && b < a + c && c < a + b)
Console.WriteLine("yes");
else
Console.WriteLine("no");






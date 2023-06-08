// Площадь треугольника

// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

// Входные данные
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. Все числа не превышают 106 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.

// Примеры
// №	            INPUT.TXT	            OUTPUT.TXT

// 1	            2 1 2 4 6 1	                6

// 2	            0 0 0 3 3 0	                4.5

Console.Clear();
Console.Write("Введите значение x1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение y1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение x2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение y2: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение x3: ");
double x3 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение y3: ");
double y3 = double.Parse(Console.ReadLine()!);
double square = 0;

double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));



Console.WriteLine($"площадь треугольника равна: ({Math.Round (a)} * {Math.Round (b)}) % 2 = {Math.Round ((a * b) / 2.0)}");



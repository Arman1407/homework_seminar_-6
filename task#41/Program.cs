// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!), positive = n, negative = 0; //, max1 = n, max2 = 0;
while (n > 0) 
{
    Console.Write("Введите число: ");
    n = int.Parse(Console.ReadLine()!);
    if (positive < n)
    {
        positive = 0;
        positive++;
    }
    
    else if (negative < n)
        positive = n;

    
      
}
Console.WriteLine(positive); 


/*
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!), max1 = n, max2 = 0;
while (n != 0) 
{
    Console.Write("Введите число: ");
    n = int.Parse(Console.ReadLine()!);
    if (max1 < n)
    {
        max2 = max1;
        max1 = n;
    }
    else if (max2 < n)
        max2 = n;
}
Console.WriteLine(max2);
*/
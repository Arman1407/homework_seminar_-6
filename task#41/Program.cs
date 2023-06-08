// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!), positive = n;
int countpositive = 0;
while (n > 0) 
{
    Console.Write("Введите число: ");
    n = int.Parse(Console.ReadLine()!);
    if (positive < n)
    {
        positive = 0;
        countpositive++;
    }
}
Console.WriteLine(countpositive); 



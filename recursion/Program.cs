// Перестановки

// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.

// Входные данные
// Входной файл INPUT.TXT содержит строку, состоящую из N символов (1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите в каждой строке по одной перестановке. Перестановки можно выводить в любом порядке. 
// Повторений и строк, не являющихся перестановками исходной, быть не должно.

// Примеры
// №	                    INPUT.TXT	                    OUTPUT.TXT

// 1	                        AB	                            AB
//                                                              BA

// 2	                        IOX	                            XOI
//                                                              OIX
//                                                              IXO
//                                                              XIO
//                                                              OXI
//                                                              IOX



void rec(string s2, string c)
{
    string s1;
    int i;
    if (s2.Length == 0)
        Console.WriteLine(c);
    else
    {
        for (i = 0; i < s2.Length; i++)
        {
            c += s2[i];
            s1 = s2;
            s1 = s1.Remove(i, 1);
            rec(s1, c);
            c = c.Remove(c.Length - 1, 1);
        }
    }
}


Console.Clear();
string? s = Console.ReadLine(), c, s2;
for(int i = 0; i < s.Length; i++)
{
    c = s[i].ToString();
    s2 = s;
    s2 = s2.Remove(i, 1);
    //Console.WriteLine(s2);
    rec(s2, c);
}

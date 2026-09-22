using System;

Console.Write("1번: ");
string frist= Console.ReadLine();
Console.Write("2번: ");
string second = Console.ReadLine();

bool same = (frist == second);
bool num = (int.Parse(frist) == int.Parse(second));

Console.WriteLine($"원문: [{frist}] / [{second}]");
Console.WriteLine($"같은 표기: {same}");
Console.WriteLine($"같은 번호: {num}");
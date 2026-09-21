using System;

Console.Write("시작 점수: ");
string start = Console.ReadLine();
int start1 = int.Parse(start);
Console.Write("획득 점수: ");
string add = Console.ReadLine();
int add1 = int.Parse(add);
Console.Write("차감 점수: ");
string minus = Console.ReadLine();
int minus1 = int.Parse(minus);

Console.WriteLine($"시작: {start1}");
Console.WriteLine($"획득 후: {start1 + add1}");
Console.WriteLine($"차감 후: {start1 + add1 - minus1}");
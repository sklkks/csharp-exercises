using System;

Console.Write("소수: ");
double aa = Convert.ToDouble(Console.ReadLine());
int bb = Convert.ToInt32(aa);
int a = (int)aa;
int cc = bb - a;

Console.WriteLine($"Convert 좌표:{bb}");
Console.WriteLine($"캐스트 좌표: {a}");
Console.WriteLine($"좌표 차이: {cc}");
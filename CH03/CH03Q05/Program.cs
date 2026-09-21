using System;

int unit_price = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());
int change = int.Parse(Console.ReadLine());

int dif = (unit_price * change - unit_price * min);

Console.WriteLine($"변경 전: {min}개 / {unit_price * min}");
Console.WriteLine($"변경 후: {change}개 / {unit_price * change}");
Console.WriteLine($"금액 차이: {dif}원");
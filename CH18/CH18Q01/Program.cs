using CH18Q01;
using System;

Console.Write("시: ");
int hour = int.Parse(Console.ReadLine());
Console.Write("분: ");
int minute = int.Parse(Console.ReadLine());
Console.Write("진행할 분: ");
int runtime = int.Parse(Console.ReadLine());

MinuteClock mi = new MinuteClock(hour, minute);
MinuteClock mi_2 = new MinuteClock(hour, minute);
Console.WriteLine($"초기: {mi.GetTime()}");
mi.Advance(runtime);
Console.WriteLine($"진행: {mi.GetTime()}");
Console.WriteLine($"다른 시계: {mi_2.GetTime()}");
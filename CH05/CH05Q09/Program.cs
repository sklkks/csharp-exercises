using System;

Console.Write("이전 지침: ");
double previous = double.Parse(Console.ReadLine());


Console.Write("현재 지침: ");
double current = double.Parse(Console.ReadLine());


Console.Write("단위당 요금: ");
decimal price = decimal.Parse(Console.ReadLine());

double total = Math.Abs(previous - current);

double excess = total % 10;

decimal settlement = price * (decimal)excess;

Console.WriteLine($"총 사용량: {total}");
Console.WriteLine($"과금 사용량: {excess}");
Console.WriteLine($"정산 금액: {Math.Round(settlement, 2, MidpointRounding.AwayFromZero)}");
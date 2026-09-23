using System;

Console.Write("전체 금액: ");
var totalprice = decimal.Parse(Console.ReadLine());

Console.Write("인원수: ");
var p = double.Parse(Console.ReadLine());

int one = (int)totalprice / (int)p;
int total = (int)p * one;
decimal nam = totalprice - total;

Console.WriteLine($"1인당 지급: {one}");
Console.WriteLine($"총 지급: {total}");
Console.WriteLine($"남은 금액: {nam}");
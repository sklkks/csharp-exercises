using System;

Console.Write("원단 전체 길이: ");
decimal total = decimal.Parse(Console.ReadLine());
Console.Write("제품 한 개에 들어가는 원단 길이: ");
decimal one = decimal.Parse(Console.ReadLine());
Console.Write("주문 수량: ");
int order = int.Parse(Console.ReadLine());

decimal make = 0.1m;
decimal onepice = one + make;
int make_Max = (int)(total / onepice);
int Abandoned = order - make_Max;
decimal remnant = total - make_Max * onepice;
decimal sale = make_Max * 12.50m;

Console.WriteLine($"처리 수량: {make_Max}");
Console.WriteLine($"미처리 수량: {Abandoned}");
Console.WriteLine($"남은 원단: {Math.Round(remnant, 1)}m");
Console.WriteLine($"판매액: {Math.Round(sale, 2)}");
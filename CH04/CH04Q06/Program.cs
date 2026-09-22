using System;

Console.Write("첫째 작업의 보상액: ");
decimal first = decimal.Parse(Console.ReadLine());
Console.Write("둘째 작업의 보상액: ");
decimal second = decimal.Parse(Console.ReadLine());


decimal first_a = Math.Round(first);
decimal total = first_a + second;
decimal total_a = Math.Round(total);

decimal all = first + second;
decimal all_a = Math.Round(all);

decimal def = Math.Abs(total_a - all_a);

Console.WriteLine($"건별 정산 {Math.Round(total_a)}");
Console.WriteLine($"합산 정산 {Math.Round(all_a)}");
Console.WriteLine($"차이 {def}");
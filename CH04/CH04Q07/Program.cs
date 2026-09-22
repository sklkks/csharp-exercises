using System;

Console.Write("측정값: ");
decimal measurements = decimal.Parse(Console.ReadLine());
Console.Write("보정값: ");
decimal Correction_value = decimal.Parse(Console.ReadLine());

measurements = measurements + Correction_value;
decimal max = 50;
decimal min = -50;

decimal def = Math.Abs(max - measurements);

Console.WriteLine($"보정 결과: {measurements}");
Console.WriteLine($"표시값: {Math.Min(measurements, max)}");
Console.WriteLine($"표시하지 못한 차이: {def}");
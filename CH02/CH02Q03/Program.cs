using System;

Console.WriteLine("=== 문구점 영수증 ===\n");

Console.WriteLine("공책: 1200원 x 3권 = 3600원");
Console.WriteLine("펜: 800원 x 2권 = 1600원\n");

Console.WriteLine($"합계: {1200 * 3 + 800 * 2}원");
Console.WriteLine($"결제: 10000원");
Console.WriteLine($"거스름돈: {10000 - 5200}원");
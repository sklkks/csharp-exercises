using System;

Console.Write("바이트 수: ");
long bytes = long.Parse(Console.ReadLine());
Console.Write("프레임 수: ");
long frames = long.Parse(Console.ReadLine());

long total = bytes * frames;
Console.WriteLine($"필요한 저장량: {total}바이트");

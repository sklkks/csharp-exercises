using System;

Console.Write("정수 신호: ");
sbyte signal = sbyte.Parse(Console.ReadLine());

byte transmitted = unchecked((byte)signal);
sbyte restored = unchecked((sbyte)transmitted);
bool Match = (signal == restored);


Console.WriteLine($"전송값: {transmitted}");
Console.WriteLine($"복원값: {restored}");
Console.WriteLine($"원본과 일치: {Match}");
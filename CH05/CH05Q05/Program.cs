using System;

Console.Write("1번 밝기: ");
byte b1 = byte.Parse(Console.ReadLine());
Console.Write("2번 밝기: ");
byte b2 = byte.Parse(Console.ReadLine());


int exactSum = b1 + b2;
byte byteSum = unchecked((byte)exactSum);
bool preservation = (exactSum == byteSum);


Console.WriteLine($"정확한 합계: {exactSum}");
Console.WriteLine($"byte 저장값: {byteSum}");
Console.WriteLine($"값 보존: {preservation}");
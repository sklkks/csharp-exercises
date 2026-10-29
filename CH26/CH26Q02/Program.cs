using System;

Console.Write("최초 보정값: ");
int firstOffset = int.Parse(Console.ReadLine());

Console.Write("새 객체 보정값: ");
int newOffset = int.Parse(Console.ReadLine());

Console.Write("원래 객체의 새 보정값: ");
int changeedOffset = int.Parse(Console.ReadLine());

Console.Write("측정값: ");
int value = int.Parse(Console.ReadLine());

Calibrator original = new Calibrator(firstOffset);
Calibrator current = original;

Func<int, int> saved = current.Adjust;
Console.WriteLine($"처음: {saved(value)}");
current = new Calibrator(newOffset);
original.Offest = changeedOffset;

Console.WriteLine($"보관:  {saved(value)}");
Console.WriteLine($"현재: {current.Adjust(value)}");
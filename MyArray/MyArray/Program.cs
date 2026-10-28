using System;

int[] array = { 50, 20, 30, 10, 50, 70, 100 };

MyArray.ForEach(array, x => Console.Write($"{x}점: "));

Console.WriteLine($"60점 이상: {MyArray.Count(array, n => n >= 60)}명");

Console.WriteLine($"만점 존재 여부: {MyArray.Exists(array, n => n == 100)}");

Console.WriteLine($"{MyArray.FindIndex(array, x => x >= 90)}");

int[] passed = MyArray.Filter(array, x => x >= 60);

passed = MyArray.Filter(array, IsEven);

MyArray.Transform(passed, x => Math.Min(x + 5, 100));

MyArray.Sort(passed, (a, b) => b.CompareTo(a));

static bool IsEven(int value)
{
    return value % 2 == 0;
}

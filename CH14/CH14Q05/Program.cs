using System;

Console.Write("원소 수: ");
int element = int.Parse(Console.ReadLine());

int[] value = new int[element];
for (int i = 0; i < element; i++)
{
    Console.Write($"{i + 1}번째 원소: ");
    value[i] = int.Parse(Console.ReadLine());
}

Console.Write("첫 하한: ");
int f_min = int.Parse(Console.ReadLine());
Console.Write("두 번째 하한: ");
int s_min = int.Parse(Console.ReadLine());

int[] original = (int[])value.Clone();

RaiseBelow(value, f_min);
string f_result = value.Length == 0 ? "[]" : "[" + string.Join(", ", value) + "]";
RaiseBelow(value, s_min);
string s_result = value.Length == 0 ? "[]" : "[" + string.Join(", ", value) + "]";

Console.WriteLine($"원본: {(original.Length == 0 ? "[]" : "[" + string.Join(", ", original) + "]")}");
Console.WriteLine($"첫 조정: {f_result}");
Console.WriteLine($"두 번째 조정: {s_result}");

void RaiseBelow(int[] arr, int minimum)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minimum)
        {
            arr[i] = minimum;
        }
    }
}
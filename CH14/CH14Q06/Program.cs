using System;

Console.Write("측정값 수: ");
int val = int.Parse(Console.ReadLine());

int[] values = new int[val];
for (int i = 0; i < val; i++)
{
    Console.Write($"{i + 1}번 측정값: ");
    values[i] = int.Parse(Console.ReadLine());
}

int[] change = GetChanges(values);

Console.WriteLine($"측정값: {(values.Length == 0 ? "[]" : "[" + string.Join(", ", values) + "]")}");
Console.WriteLine($"차이: {(change.Length == 0 ? "[]" : "[" + string.Join(", ", change) + "]")}");

int[] GetChanges(int[] arr)
{
    if (arr.Length < 2)
    {
        return new int[0];
    }

    int[] result = new int[arr.Length - 1];
    for (int i = 1; i < arr.Length; i++)
    {
        result[i - 1] = arr[i] - arr[i - 1];
    }
    return result;
}
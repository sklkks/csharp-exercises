using System;

string memo = string.Empty;

int line = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < line; i++)
{
    string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        continue;
    }

    if (memo.Length > 0)
    {
        memo += ", ";
    }

    memo += input;
    count++;
}
Console.WriteLine($"[{memo}]");
Console.WriteLine($"남긴 메모: {count}");
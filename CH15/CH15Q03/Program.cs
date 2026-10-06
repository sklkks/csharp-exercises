using System;

Console.Write("입력 줄 수: ");
int line = int.Parse(Console.ReadLine());

for(int i = 0; i < line; i++)
{
    Console.Write($"{i + 1}번째 구간: ");
    string input = Console.ReadLine();
    if(TryParseRange(input, out int start, out int end))
    {
        int count = end - start + 1;
        Console.WriteLine($"개수: {count}");
    }
    else
    {
        Console.WriteLine($"False: {start}, {end}");
    }
}



bool TryParseRange(string text, out int start, out int end)
{
    start = 0;
    end = 0;

    string[] parts = text.Split(':');
    if (parts.Length != 2)
    {
        return false;
    }

    if (!int.TryParse(parts[0], out start) || !int.TryParse(parts[1], out end))
    {
        start = 0;
        end = 0;
        return false;
    }
    if (start < 0 || start > 100 || end < 0 || end > 100 || start > end)
    {
        start = 0;
        end = 0;
        return false;
    }

    return true;
}
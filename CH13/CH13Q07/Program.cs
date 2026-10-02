using System;

Console.Write("입력 수: ");
int num = int.Parse(Console.ReadLine());

int count = 0;
int same = 0;
int x = 0;

string[] a = new string[num];

for (int i = 0; i < num; i++)
{
    Console.Write($"{i + 1}번째 이름: ");
    string input = Console.ReadLine();

    string name = (input ?? string.Empty).Trim();

    if (string.IsNullOrEmpty(name))
    {
        x++;
        continue;
    }

    bool valid = false;
    for (int j = 0; j < count; j++)
    {
        if (string.Equals(a[j], name, StringComparison.OrdinalIgnoreCase))
        {
            valid = true;
            break;
        }
    }

    if (valid)
    {
        same++;
    }
    else
    {
        a[count++] = name;
    }

}
Console.WriteLine($"명단: [{string.Join(", ", a, 0, count)}]");
Console.WriteLine($"등록: {count}");
Console.WriteLine($"중복: {same}");
Console.WriteLine($"빈 입력: {x}");
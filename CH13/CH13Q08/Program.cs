using System;

Console.Write("시작 이름:");
string start = Console.ReadLine();
Console.Write("끝 이름:");
string end = Console.ReadLine();


Console.Write("조회할 이름 수:");
int names = int.Parse(Console.ReadLine());

if (string.Compare(start, end, StringComparison.Ordinal) > 0)
{
    Console.WriteLine("범위 오류");
}
else
{
    string[] select = new string[names];
    int count = 0;

    for (int i = 0; i < names; i++)
    {
        Console.Write($"{i + 1}번째 조회 이름: ");
        string name = Console.ReadLine();

        if (string.Compare(name, start, StringComparison.Ordinal) >= 0 &&
            string.Compare(name, end, StringComparison.Ordinal) <= 0)
        {
            select[count] = name;
            count++;
        }
    }
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"이름: {select[i]}");
    }
    Console.WriteLine($"개수: {count}");
}

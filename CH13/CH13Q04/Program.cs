using System;

Console.Write("보관 칸 이름(쉼표로 구분): ");
string s = Console.ReadLine(); // 책,,  ,필기 도구,

string[] w = s.Split(',');

int count = 0;

for (int i = 0; i < w.Length; i++)
{

    string item = w[i].Trim();

    if (string.IsNullOrEmpty(item))
    {
        w[i] = "(비어있음)";
        count++;
    }
    else
    {
        w[i] = item;
    }
}

Console.WriteLine($"칸 수: {w.Length}");
Console.WriteLine($"빈 칸: {count}");
Console.WriteLine($"보관표: [{string.Join(" | ", w)}]");

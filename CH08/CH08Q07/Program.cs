using System;
using System.Xml.Linq;

Console.Write("철수: ");
int chul = int.Parse(Console.ReadLine());

Console.Write("영희: ");
int young = int.Parse(Console.ReadLine());

Console.Write("민수: ");
int minsu = int.Parse(Console.ReadLine());

int max_score = Math.Max(chul, Math.Max(young, minsu));
int count = 0;

if (max_score >= 60)
{
    if (max_score == chul)
    {
        Console.WriteLine($"철수: {chul}");
        count++;
    }

    if (max_score == young)
    {
        Console.WriteLine($"영희: {young}");
        count++;
    }

    if (max_score == minsu)
    {
        Console.WriteLine($"민수: {minsu}");
        count++;
    }
}

Console.WriteLine($"선발 인원: {count}");

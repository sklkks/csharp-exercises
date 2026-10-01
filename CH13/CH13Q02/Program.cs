using System;

Console.Write("원본 문장:");
string text = Console.ReadLine();

Console.Write("교체 내용:");
string replace = Console.ReadLine();

string result = text;

int start = text.IndexOf('[');
int end = text.IndexOf(']');

if (start != -1 && end != -1 && end > start)
{
    result = text.Remove(start, (end - start) + 1)
                 .Insert(start, replace);
}

Console.WriteLine($"원본: [{text}]");
Console.WriteLine($"결과: [{result}]");
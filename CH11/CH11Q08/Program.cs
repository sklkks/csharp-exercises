using System;

int n = int.Parse(Console.ReadLine());
int[] person = new int[n];
string[] name = new string[n];


for (int i = 0; i < n; i++)
{
    name[i] = Console.ReadLine();
}

int move = int.Parse(Console.ReadLine());

string[] changed = new string[n];
for (int i = 0; i < n; i++)
{
    changed[(i + move) % n] = name[i];
}

Console.Write("원본:");
for (int i = 0; i < n; i++)
{
    Console.Write($" {name[i]}");
}
Console.WriteLine();

Console.Write("변경:");
for (int i = 0; i < n; i++)
{
    Console.Write($" {changed[i]}");
}
Console.WriteLine();

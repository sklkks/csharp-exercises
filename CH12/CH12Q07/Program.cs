using System;


Console.Write("초기 포인트: ");
int point = int.Parse(Console.ReadLine());
Console.Write("변경 횟수: ");
int count = int.Parse(Console.ReadLine());

string[] history = new string[count];
string format = "{0:D2}: {1} -> {2}(요청: {3}, 반영: {4})";

for (int i = 0; i < count; i++)
{
    Console.Write($"{i+1}번 변경 요청량: ");
    int request = int.Parse(Console.ReadLine());
    int before = point;
    point = Math.Clamp(point + request, 0, 100);

    int applied = point - before;
    history[i] = string.Format(format, i + 1, before, point, request, applied);
}

Console.WriteLine($"최종: {point}");
foreach (string line in history)
{
    Console.WriteLine(line);
}
using CH20Q02;
using System;
using System.Text;

Console.Write("기록 용량: ");
int capacity = int.Parse(Console.ReadLine());

Console.Write("요청 수: ");
int count = int.Parse(Console.ReadLine());

PositiveRecorder aa = new PositiveRecorder(capacity);
for (int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 기록값: ");
    int num_count = int.Parse(Console.ReadLine());

    bool appended = aa.Record(num_count);
    Console.WriteLine($"{appended}: {aa.Count}개 {aa.Describe()}");
}
Console.WriteLine($"최종: {aa.Describe()} / 용량{capacity}");

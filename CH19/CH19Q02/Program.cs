using System;
using CH19Q02;

Console.Write("기록 수: ");
int num = int.Parse(Console.ReadLine());

RangeLog log = new RangeLog(num);

for (int i = 0; i < num; i++)
{
    Console.Write($"{i + 1}번 기록값: ");
    int count = int.Parse(Console.ReadLine());
    log.Record(count);
    Console.WriteLine($"{i+1}개: {log.Minimum}~{log.Maximum}, 폭 {log.Spread}");
}
Console.WriteLine($"최종: {log.Count}개, {log.Minimum}~{log.Maximum}, 폭 {log.Spread}");


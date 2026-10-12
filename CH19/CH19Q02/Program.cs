using System;


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

class RangeLog
{
    public int Count { get; private set; }
    public int Minimum { get; private set; }
    public int Maximum { get; private set; }
    public int Spread;

    public RangeLog(int value)
    {
        Count = value;
        Minimum = int.MaxValue;
        Maximum = int.MinValue;
        Spread = 0;
    }

    public void Record(int value)
    {
        if (value < Minimum) Minimum = value;
        if (value > Maximum) Maximum = value;
        Spread = Maximum - Minimum;
    }
}

using System;
using CH17Q02;


using System;
using System.Collections.Generic;
using System.Text;


AverageRecorder recorders = new AverageRecorder();

Console.Write("기록 수: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > 6)
{
    return;
}

for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"\n[기록 {i}]");

        Console.Write("기록기 번호: ");
        int recorderId = int.Parse(Console.ReadLine());

        Console.Write("값: ");
        int value = int.Parse(Console.ReadLine());

        recorders[recorderId].Add(value);
        
        Console.WriteLine($"{recorderId}: {recorders[recorderId].GetCount()}개, 평균 {recorders[recorderId].GetAverage():F1}");
    }

Console.WriteLine("\n최종");
for (int i = 0; i<recorders.Length; i++)
    {
        Console.WriteLine($"{i}: {recorders[i].GetCount()}개, 평균 {recorders[i].GetAverage():F1}");
    }

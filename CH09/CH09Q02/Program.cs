using System;

int count = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < count; i++)
{
    int value = int.Parse(Console.ReadLine());
    sum += value;
}
Console.WriteLine($"합계: {sum}");
if (count == 0)
{
    Console.WriteLine("측정 없음");
}
else
{
    double avg = (double)sum / count;
    avg = Math.Round(avg, 2);
    Console.WriteLine($"평균: {avg}");
}
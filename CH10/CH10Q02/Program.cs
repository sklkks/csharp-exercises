using System;

int count = int.Parse(Console.ReadLine());

int success_count = 0;
int failed_count = 0;
int sum = 0;

for (int i = 0; i < count; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num < 0)
    {
        failed_count++;
        continue;
    }

    success_count++;
    sum += num;
}

Console.WriteLine($"정상 기록: {success_count}");
Console.WriteLine($"제외 기록: {failed_count}");
Console.WriteLine($"생산량: {sum}");
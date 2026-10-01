using System;

Console.Write("참여자 수: ");
int n = int.Parse(Console.ReadLine());

int total_score = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"[참여자 {i + 1}]");

    Console.Write("기록 개수: ");
    int count = int.Parse(Console.ReadLine());

    if (count == 0)
    {
        Console.WriteLine($"전체 기록: {count}");
        continue;
    }

    int[] score = new int[count];
    int sum = 0;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{j + 1}회차 기록: ");
        score[j] = int.Parse(Console.ReadLine());

        sum += score[j];
        total_score += score[j];
    }

    Console.WriteLine($"{i + 1}회차: {count}명, 합계 {sum}");
    Console.WriteLine($"전체 기록: {total_score}");
}
using System;

Console.Write("첫 영상의 분: ");
int first_min = int.Parse(Console.ReadLine());
Console.Write("첫 영상의 초: ");
int first_sec = int.Parse(Console.ReadLine());
Console.Write("두 번째 영상의 분: ");
int second_min = int.Parse(Console.ReadLine());
Console.Write("두 번째 영상의 초: ");
int second_sec = int.Parse(Console.ReadLine());

int first_total_video = first_min * 60 + first_sec;
int second_total_video = second_min * 60 + second_sec;
int total_video = first_total_video + second_total_video;

Console.WriteLine();
Console.WriteLine($"첫 영상: {first_min * 60 + first_sec}초");
Console.WriteLine($"두 번째 영상: {second_min * 60 + second_sec}초");
Console.WriteLine($"합계: {total_video}초");
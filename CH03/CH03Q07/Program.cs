using System;

Console.Write("철수 점수: ");
int cheolsuscore = int.Parse(Console.ReadLine());
Console.Write("영희 점수: ");
int younghuiscore = int.Parse(Console.ReadLine());

int tradeScore = cheolsuscore; //영희와 교환할 점수
int tradeScore2 = younghuiscore; //철수와 교환할 점수

Console.WriteLine($"교환 전: 철수 {cheolsuscore} / 영희 {younghuiscore}");
Console.WriteLine($"교환 후: 철수 {tradeScore2} / 영희 {tradeScore}");
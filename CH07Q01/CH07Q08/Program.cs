using System;

Console.Write("");
int current = int.Parse(Console.ReadLine());

Console.Write("");
int move = int.Parse(Console.ReadLine());

int total = 8;
int move2 = current + move;
int next = (move2 % total + total) % total;
bool passed = (move > 0 && move2 >= total) || (move < 0 && move2 < 0) || (Math.Abs(move) >= total);

Console.WriteLine($"선택 칸: {next}");
Console.WriteLine($"경계 통과: {passed}");
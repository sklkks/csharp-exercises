using System;

Console.Write("첫째 이동량: ");
decimal frist = decimal.Parse(Console.ReadLine());

Console.Write("둘째 이동량: ");
decimal second = decimal.Parse(Console.ReadLine());

decimal total = frist + second;
int frist_int = (int)frist;
decimal frist_decimal = Math.Abs(frist - frist_int);

int second_int = (int)(second + frist_decimal);
decimal second_decimal = Math.Abs(second - second_int);

decimal final = total - (frist_int + second_int);
int total_transfer = frist_int + second_int;

Console.WriteLine($"첫 전송: {frist_int}");
Console.WriteLine($"두 번째 전송: {second_int}");
Console.WriteLine($"최종 잔량: {final}");
Console.WriteLine($"총 전송량: {total_transfer}");
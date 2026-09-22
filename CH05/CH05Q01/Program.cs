using System;

Console.Write("구역 순번: ");
int Zone_num = int.Parse(Console.ReadLine());
Console.Write("좌석 번호: ");
int seat_num = int.Parse(Console.ReadLine());

char Zone = (char)('A' + Zone_num - 1);




Console.WriteLine($"좌석: {Zone}-{seat_num}");

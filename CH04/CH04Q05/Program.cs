using System;

Console.Write("주차한 시간(분): ");
int P_time = int.Parse(Console.ReadLine());

int OverParking = (P_time / 60);
int Pay = ((P_time + 59) / 60);
int charge = (Pay * 1500);

Console.WriteLine($"완전히 지난 시간: {OverParking}");
Console.WriteLine($"과금 시간: {Pay}");
Console.WriteLine($"요금: {charge}원");
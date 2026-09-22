using System;

Console.Write("소수 좌표: ");
decimal coordinate = decimal.Parse(Console.ReadLine());

int Integer_coordinate = (int)coordinate;
decimal movement = coordinate - Integer_coordinate;

Console.WriteLine($"원본: {coordinate}");
Console.WriteLine($"정수 좌표: {Integer_coordinate}");
Console.WriteLine($"잔여 이동: {movement}");

using System;

Console.Write("시작 위치: ");
float start = float.Parse(Console.ReadLine());
Console.Write("이동 량: ");
double move = double.Parse(Console.ReadLine());

float before = start;
double doubleStart = start;

start = start +(float)move;
doubleStart = doubleStart + move;

Console.WriteLine($"float 반영량: {start - before}");
Console.WriteLine($"double 반영량: {doubleStart - before}");

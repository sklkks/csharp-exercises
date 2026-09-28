using System;

Console.Write("철수: ");
int chul = int.Parse(Console.ReadLine());
Console.Write("영희: ");
int young = int.Parse(Console.ReadLine());

int a = chul < young ? chul : young;
string name = chul < young ? "철수" : "영희";

Console.WriteLine($"담당자: {name}");
Console.WriteLine($"쇼요시간: {a}분");
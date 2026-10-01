using System;

Console.Write("시작 번호: ");
int start = int.Parse(Console.ReadLine());
Console.Write("발급 개수: ");
int count = int.Parse(Console.ReadLine());

for (int  i = 0; i < count; i++)
{
    int number = start + i;
    Console.WriteLine($"번호 {number:D4} /코드{number:X4}");
}

if (count == 0)
{
    Console.WriteLine("발급 없음");
}
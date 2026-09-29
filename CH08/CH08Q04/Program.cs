using System;

Console.Write("복사할 장수 입력: ");
int copy = int.Parse(Console.ReadLine());
int total = 0;
if (copy >= 1 && copy < 11)
{
    total = copy * 100;
}
else if (copy >= 11 && copy < 51)
{
    total = 10 * 100 + (copy - 10) * 80;
}
else if (copy >= 51)
{
    total = 10 * 100 + 40 * 80 + (copy - 50) * 60;
}

Console.WriteLine($"복사요금: {total}원");
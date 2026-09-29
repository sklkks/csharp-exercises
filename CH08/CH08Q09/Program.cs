using System;

int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int page = 0;

if (start >= 1) 
{
    start = start;
}

if (end > 1 && end <= 100)
{
    end = end;
}

if (start > end)
{
    Console.Write($"ㅌ");
    return 0;
}

if (start < 1)
{
    page += Math.Abs(start - 0);
    start = 1;
  
}


if (end > 100 && end < 1)
{
    end = Math.Abs(end);
    page += Math.Abs(end - 100);
    end = 100;
}

if (-1000 < start && start < 1 && end < -1000 && end < 1)
{
    Console.WriteLine("출력할 페이지 없음:");
}

Console.WriteLine($"출력 범위: {start}~{end}");
Console.WriteLine($"출력 장수: {Math.Abs(start - end)+1}");
Console.WriteLine($"제외된 장수: {page}");

return 0;
using System;

int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

if (start > end)
{
    Console.WriteLine("잘못된 순서");
}

else if (end < 1 || start > 100)
{
    Console.WriteLine("출력할 페이지 없음");
}

else
{
    int actual_start = start;
    if (actual_start < 1)
    {
        actual_start = 1;
    }

    int actual_end = end;
    if (actual_end > 100)
    {
        actual_end = 100;
    }

    int count = actual_end - actual_start + 1;

    int total = end - start + 1;

    int excluded = total - count;

    Console.WriteLine("출력 범위: " + actual_start + "~" + actual_end);
    Console.WriteLine("출력 장수: " + count);
    Console.WriteLine("제외된 장수: " + excluded);
}
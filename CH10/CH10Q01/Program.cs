using System;

int count = int.Parse(Console.ReadLine());
int target = int.Parse(Console.ReadLine());

int found = -1; 
int check_count = 0;

for (int i = 0; i < count; i++)
{
    int product = int.Parse(Console.ReadLine());
    check_count++;

    if (product == target)
    {
        found = i + 1;
        break;
    }
}

if (found != -1)
{
    Console.WriteLine($"첫 위치: {found}");
}
else
{
    Console.WriteLine("상품 없음");
}

Console.WriteLine($"검사 수: {check_count}");
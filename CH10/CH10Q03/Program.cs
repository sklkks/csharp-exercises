using System;

int limit = int.Parse(Console.ReadLine());
int success_count = 0;
int failed_count = 0;
int sum = 0;

for (int i = 0; i < limit; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;

    if (num == 0)
    {
        continue;
    }

    else if (sum > limit)
    {
        sum -= num;
        failed_count++;
        break;       
    }

   
    success_count++;
}
Console.WriteLine($"적재 개수: {success_count}");
Console.WriteLine($"총무게: {sum}");
Console.WriteLine($"중단 물품: {failed_count}");
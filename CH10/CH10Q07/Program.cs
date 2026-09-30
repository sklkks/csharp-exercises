using System;

int bundle = int.Parse(Console.ReadLine());
int total = 0;

for(int i = 0; i < bundle; i++)
{
    int count = 0;
    int sum = 0;

    while (true)
    {

        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            continue;
        }

        if (num == 0)
        {
            break;
        }

        sum += num;
        count++;

    }
    Console.WriteLine($"묶음 {i + 1}: {count}건 / {sum}개");

    total += sum;
}

Console.WriteLine($"전체 수량: {total}");


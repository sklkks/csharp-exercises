using System;

int count = int.Parse(Console.ReadLine());

if (count >= 1 && count <= 10)
{
    int recoed = 0;
    int current_streak = 0;
    int prev = 0;
    bool asd = false;

    for (int i = 0; i < count; i++)
    {
        int current = int.Parse(Console.ReadLine());

        if (current < -20 || current > 20)
        {
            asd = true;
            break;
        }

        if (i == 0)
        {
            prev = current;
        }

        else
        {
            if (current > prev)
            {
                current_streak = current_streak + 1;
            }

            else
            {
                current_streak = 0;
            }

            if (current_streak > recoed)
            {
                recoed = current_streak;
            }

            prev = current;
        }
    }

    if (!asd)
    {
        Console.WriteLine("최장 연속 상승: " + recoed);
    }
}
using System;

int count = int.Parse(Console.ReadLine());

if (count >= 0 && count <= 8)
{
    int total = 1;
    bool valid = true;

    for (int i = 0; i < count; i++)
    {
        int scale = int.Parse(Console.ReadLine());

        if (scale >= 1 && scale <= 5)
        {
            total = total * scale;
        }
        else
        {
            valid = false;
            break;
        }
    }

    if (valid)
    {
        Console.WriteLine("합성 배율: " + total);
    }
}


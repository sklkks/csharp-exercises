using System;

int count = int.Parse(Console.ReadLine());

if (count == 0)
{
    Console.WriteLine("측정 없음");
}
else if (count >= 1 && count <= 10)
{
    int max_record = 0;
    int update = 0;
    bool first = true;
    bool leave = false;

    for (int i = 0; i < count; i++)
    {
        int current = int.Parse(Console.ReadLine());

        if (current < -100 || current > 100)
        { 
            leave = true;
            break;
        }

        if (first)
        {
            max_record = current;
            update = update + 1;
            Console.WriteLine("기록 갱신: " + current);
            first = false;
        }
        else
        {
            if (current > max_record)
            {
                max_record = current;
                update = update + 1;
                Console.WriteLine("기록 갱신: " + current);
            }
        }
    }
    if (!leave)
    {
        Console.WriteLine("최고 기록: " + max_record);
        Console.WriteLine("갱신 횟수: " + update);
    }
}
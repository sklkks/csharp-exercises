using System;

int start = int.Parse(Console.ReadLine());
int interval = int.Parse(Console.ReadLine());
int count = int.Parse(Console.ReadLine());

if (start >= 1 && start <= 1000 && interval >= 1 && interval <= 10 &&
    count >= 0 && count <= 10)
{
    int current_num = start;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine("발급: " + current_num);
        current_num = current_num + interval;
    }

    Console.WriteLine("다음 번호: " + current_num);
}

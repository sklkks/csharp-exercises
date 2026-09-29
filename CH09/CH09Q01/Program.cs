using System;

int fir = int.Parse(Console.ReadLine());
int interval = int.Parse(Console.ReadLine());
int items = int.Parse(Console.ReadLine());
int sum = 0;
int i = 0;

for (; i < items; i ++)
{
    Console.WriteLine($"발급: {fir + sum}");
    sum += interval;



}
if(i == 3)
{
    Console.WriteLine($"다음 번호: {fir + sum}");
}




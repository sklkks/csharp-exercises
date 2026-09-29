using System;

Console.Write("온도: ");
int temperature = int.Parse(Console.ReadLine());
Console.Write("습도: ");
int humidty = int.Parse(Console.ReadLine());

int waring_count = 0;

if (temperature > 30)
{
    Console.WriteLine("온도 경고");
    ++waring_count;
}
if (humidty > 70)
{
    Console.WriteLine("습도 경고");
    ++waring_count;
}

Console.WriteLine($"경고 수: {waring_count}");
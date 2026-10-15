using System;
using CH22Q02;

Console.Write("요청 수: ");
int count = int.Parse(Console.ReadLine());

SessionCounter counter = new SessionCounter();
ISession session = counter;
ILifetime lifetime = counter;

for (int i = 0; i < count; i++)
{
    Console.WriteLine();
    Console.WriteLine($"[요청 {i + 1}]");
    Console.Write("동작: ");
    string st = Console.ReadLine();

    if(st == "추가")
    {
        Console.Write("추가할 값: ");
        int ad = int.Parse(Console.ReadLine());
        bool isSuccess = counter.Add(ad);
        Console.WriteLine($"{st} {isSuccess}: {counter.sum}/{counter.totalSum}");
    }
    if(st == "회차초기화")
    {
        session.Reset();
        Console.WriteLine($"{st}: {counter.sum}/{counter.totalSum}");
    }
    
    if(st == "누적초기화")
    {
        lifetime.Reset();
        Console.WriteLine($"{st}: {counter.sum}/{counter.totalSum}");
    }
}
Console.WriteLine();
Console.WriteLine($"최종: {counter.sum}/{counter.totalSum}");
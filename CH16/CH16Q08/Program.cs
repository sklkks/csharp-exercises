using System;
using CH16Q08;

Console.Write("창구 수: ");
int count = int.Parse(Console.ReadLine());

Counter[] counters = new Counter[count];
for(int i = 0; i < count; i++)
{
    counters[i] = new Counter();
    Console.WriteLine($"[창구 {i + 1}]");
    Console.Write("이름: ");
    counters[i].Name = Console.ReadLine();
    Console.Write("수용 한도: ");
    counters[i].Capacity = int.Parse(Console.ReadLine());
    Console.Write("현재 대기 인원: ");
    counters[i].Waiting = int.Parse(Console.ReadLine());

}

Console.Write("요청 수: ");
int requestCount = int.Parse(Console.ReadLine());

for(int i = 0;i < requestCount; i++)
{
    Console.Write($"{i + 1}번 요청 인원: ");
    int amount = int.Parse(Console.ReadLine());
    
    Counter selected = null;
    foreach(Counter counter in counters)
    {
        if(counter.CanAccept(amount) && 
            (selected == null || counter.Waiting < selected.Waiting))
        {
            selected = counter;

        }
    }
    if(selected == null)
    {
        Console.WriteLine("배정 불가");
    }
    else
    {
        selected.Accept(amount);
        Console.WriteLine($"{selected.Name}: {selected.Waiting}");
    }
}

Console.WriteLine("최종 대기");
foreach(Counter counter in counters)
{
    Console.WriteLine($"{counter.Name}: {counter.Waiting}");
}

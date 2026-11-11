using System;
using System.Linq;
using System.Collections.Generic;

Console.Write("최소 우선순위 / 페이지 번호 / 페이지 크기/ 작업 수(공백 구분): ");
string[] header = Console.ReadLine().Split(' ');
int minimum = int.Parse(header[0]);
int page = int.Parse(header[1]);
int size = int.Parse(header[2]);
int count = int.Parse(header[3]);

List<Job> jobs = new List<Job>();
for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 작업 (번호 우선순위 비용 준비여부): ");
    string[] parts = Console.ReadLine().Split(' ');
    jobs.Add(new Job(
        int.Parse(parts[0]), 
        int.Parse(parts[1]),
        int.Parse(parts[2]),
        parts[3] == "1"));
}


var query = from job in jobs 
            where job.Ready &&job.Priority >= minimum
            orderby job.Priority descending, job.Cost, job.Id
            select job;

string[] lines = query.Select((x, i) => 
    $"{i + 1}. " +
    $"번호 {x.Id}, " +
    $"우선 {x.Priority}, " +
    $"비용{x.Cost}").ToArray();

string[] selected = lines.Skip((page - 1) * size).Take(size).ToArray();
Console.WriteLine($"전체: {selected.Length}");


foreach (var job in query)
{
    Console.WriteLine(job);
}

class Job
{
    public int Id { get; }
    public int Priority { get; }
    public int Cost { get; }
    public bool Ready { get; }

    public Job(int id, int priority, int cost, bool ready)
    {
        Id = id;
        Priority = priority;
        Cost = cost;
        Ready = ready;
    }

    public override string ToString()
    {
        return $"{Id} / {Priority} / {Cost} / {Ready}";
    }
}

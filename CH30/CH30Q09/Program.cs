using System;
using System.Linq;
using System.Collections.Generic;

Console.Write("원본 값 수: ");
int count = int.Parse(Console.ReadLine());
Queue<int> queue = new Queue<int>();
for(int i = 0; i < count; i++)
{
    Console.Write($"{i + 1}번 원본 값: ");
    queue.Enqueue(int.Parse(Console.ReadLine()));

}
WorkSource source = new WorkSource(queue);

Console.Write("요청 수: ");
int requests = int.Parse(Console.ReadLine());
for(int i = 0;i < requests; i++)
{
    Console.Write($"{i + 1} 번째 요청 목표 수: ");
    int target = int.Parse(Console.ReadLine());

    List<int> batch = source.Read().Where(x => x >= 0 && x % 2 == 0).Take(target).ToList();
    Console.WriteLine($"개수 {batch.Count}, 합계{batch.Sum()}, 평균{batch.Average()}");
    Console.WriteLine($"꺼낸 수: {source.ReadCount}, 남음: {source.DescribeRemainings()}");

}

class WorkSource
{


    private Queue<int> queue;
    public int ReadCount { get; private set;  }

    public WorkSource(Queue<int> queue)
    {
        this.queue = queue;
    }

    public IEnumerable<int> Read()
    {
        while (queue.Count > 0)
        {
            int value = queue.Dequeue();
            ReadCount++;
            yield return value;
        }
    }

    public string DescribeRemainings()
    {
        return queue.Count == 0 ? "없음" : string.Join(",", queue); 
    }
}
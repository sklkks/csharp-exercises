using System;
using CH21Q01;

Console.Write("정수 값: ");
int value = int.Parse(Console.ReadLine());

Console.Write("눈금 간격: ");
int interval = int.Parse(Console.ReadLine());

ValueRule[] rules = 
{
        new ValueRule(interval),
        new FloorRule(interval),
        new NearestRule(interval)
};
foreach (ValueRule rule in rules)
{
    Console.WriteLine($"{rule.GetType().Name}: {rule.Adjust(value)}");
}

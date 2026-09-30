using System;

int bins = int.Parse(Console.ReadLine());
int[] numbers = new int[bins];
int inbound = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < inbound; i++)
{
    int num = int.Parse(Console.ReadLine());
    int items = int.Parse(Console.ReadLine());
    numbers[num - 1] += items; 
}

foreach (int value in numbers)
{
    sum += value;
}
for (int i = 0; i < bins; i++)
{
    Console.WriteLine($"{i + 1}번: {numbers[i]}");

}
Console.WriteLine($"전체: {sum}");
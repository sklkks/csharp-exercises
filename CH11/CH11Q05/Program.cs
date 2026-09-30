using System;

int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];

int sum = 0;


for (int i = 0; i < n; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

int count = 0;

for (int i = 1; i < n; i++)
    {
    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
    {
        Console.WriteLine($"{i + 1}번: {numbers[i]}");

        count++;
    }
}
Console.WriteLine($"개수: {count}");
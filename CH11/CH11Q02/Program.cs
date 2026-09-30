using System;

int length = int.Parse(Console.ReadLine());
int[] numbers = new int[length];

for (int i = 0; i < length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < length / 2; i++)
{
    int temp = numbers[i];
    numbers[i] = numbers[length - 1 - i];
    numbers[length - 1 - i] = temp;
}

if (length == 0)
{
    Console.WriteLine("목록:");
}
else
{
    foreach (int number in numbers)
    {
        Console.WriteLine($"목록: {number}");
    }
}
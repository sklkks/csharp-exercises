using System;

int length = int.Parse(Console.ReadLine());
int[] numbers = new int[length];

for (int i = 0; i < length; i++)
{
    int number = int.Parse(Console.ReadLine()); 
    numbers[i] = number;
}
Array.Reverse(numbers);
foreach (int number in numbers)
{
    Console.WriteLine($"목록: {number}");
}

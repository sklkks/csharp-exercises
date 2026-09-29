using System;

int number = int.Parse(Console.ReadLine());
int a = 1;

for (int i = 0; i < number; i++)
{
    
    int input = int.Parse(Console.ReadLine());
    a *= input;
}

Console.WriteLine($"합성 배율: {a}");
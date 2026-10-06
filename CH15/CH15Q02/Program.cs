using System;

Console.Write("첫째 값: ");
int first = int.Parse(Console.ReadLine());
Console.Write("둘째 값: ");
int second = int.Parse(Console.ReadLine());
Console.Write("셋째 값: ");
int third = int.Parse(Console.ReadLine());

Console.WriteLine($"시작: {first}, {second}, {third}");

for(int i = 0; i < 2; i++)
{
    RotateRight(ref first, ref second, ref third);
    Console.WriteLine($"{i+1}회: {first}, {second}, {third}");
}

void RotateRight(ref int first, ref int second, ref int third)
{
    int tmp = third;
    third = second;
    second = first;
    first = tmp;
}
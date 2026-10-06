using System;

Console.Write("정수: ");
int a = int.Parse(Console.ReadLine());
Console.Write("찾을 숫자: ");
int b = int.Parse(Console.ReadLine());

int count = CountDigit(a, b);

Console.WriteLine($"출현 횟수: {count}");
int CountDigit(int number, int digit)
{
    if (number < 10)
    {
        return (number == digit) ? 1 : 0;
    }
    int find = (number % 10 == digit) ? 1 : 0;
    return find + CountDigit(number / 10, digit);
}